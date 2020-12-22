using System;
using System.Collections.Generic;
using System.Text;

namespace IObserver_03 {

    class ConcreteSubject:IObservable<string>, IDisposable {

        public string State { get; set; }
        List<IObserver<string>> observers = new List<IObserver<string>>();

        public void Notify() {
            foreach(IObserver<string> observer in observers)
                if(this.State == null)
                    observer.OnError(new NullReferenceException());
                else
            observer.OnNext(this.State); // model push
        }
        public void Dispose() {
            observers.Clear();
        }

        public IDisposable Subscribe(IObserver<string> observer) {
            if(!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }
    }

    class Unsubscriber:IDisposable {
        List<IObserver<string>> observers;
        IObserver<string> observer;

        public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer) {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose() {
            if(observers.Contains(observer))
                observers.Remove(observer);
            else
                observer.OnError(new Exception("Данный подписчик не подписан на издателя."));
        }
    }

    class ConcreteObserver:IObserver<string> {
        string name;
        string observerState;
        IDisposable unsubscriber;

        public ConcreteObserver(string name, IObservable<string> subject) {
            this.name = name;
            unsubscriber = subject.Subscribe(this);
        }

        public void OnCompleted() {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Observer {0}, Error: {1}", name, error.Message); ;
        }

        public void OnNext(string value) {
            observerState = value;
            Console.WriteLine("Observer {0}, State = {1}", name, observerState);
        }
    }
    class Program {
        static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;
            // Создание издателя.
            ConcreteSubject subject = new ConcreteSubject();

            // Создание подписчиков.
            ConcreteObserver observer1 = new ConcreteObserver("1", subject);
            ConcreteObserver observer2 = new ConcreteObserver("2", subject);
            ConcreteObserver observer3 = new ConcreteObserver("3", subject);
            ConcreteObserver observer4 = new ConcreteObserver("4", subject);

            // Подписание подписчиков на издателя с получением объекта для отписки.
            IDisposable unsubscriber1 = subject.Subscribe(observer1);
            IDisposable unsubscriber2 = subject.Subscribe(observer2);
            _ = subject.Subscribe(observer3);
            _ = subject.Subscribe(observer4);

            using(subject) {
                // Попытка предоставить обзерверам некорректное состояние.
                subject.State = null;
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "1");

                // Отписка первого подписчика через ConcreteSubject.Unsubscriber.Dispose()
                using(unsubscriber1) {
                    // Попытка предоставить обзерверам корректное состояние.
                    subject.State = "State 1 ...";
                    subject.Notify();
                }

                Console.WriteLine(new string('-', 70) + "2");

                // State 2 - получат только три подписчика которые остались подписанными.
                subject.State = "State 2 ...";
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "3");

                // Отписка второго подписчика через ConcreteObserver.OnCompleted()
                observer2.OnCompleted();

                // State 3 - получат только 2 подписчика которые остались подписанными.
                subject.State = "State 3 ...";
                subject.Notify();
            } // observers.Clear()

            Console.WriteLine(new string('-', 70) + "4");

            // Попытка отписать уже отписанного подписчика, обрабатывается в
            // ConcreteSubject.Unsubscriber.Dispose()
            observer4.OnCompleted();

            // Delay.
            Console.ReadKey();
        }
    }
}
