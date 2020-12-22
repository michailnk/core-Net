using System;
using System.Collections;

namespace Observer_01_Pull_Model_ {

    abstract class Subject {
        ArrayList observers = new ArrayList();
        public void Attach(Observer observer) {
            observers.Add(observer);
        }
        public void Detach(Observer observer) {
            observers.Remove(observer);
        }
        public void Notify() {
            foreach(Observer observer in observers)
                observer.Update();
        }
    }
    class ConcreteSubject:Subject {
        public string State { get; set; }
    }
    public abstract class Observer {
        public abstract void Update();
    }
    class ConcreteObserver:Observer {
        string observerState;
        ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject) {
            this.subject = subject;
        }
        public override void Update() {
            observerState = subject.State;
            Console.WriteLine(this.observerState + " " + GetHashCode()) ;
        }
    }

    class Program {
        static void Main(string[] args) {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));
            subject.State = "Some State...";
            subject.Notify();

        }
    }
}
