using System;
using System.Collections;

namespace Observer_02_Push_Model_ {
    abstract class Subject {
        ArrayList observers = new ArrayList();
        public abstract string State { get; set; }

        public void Attach(Observer observer) {
            observers.Add(observer);
        }
        public void Detach(Observer observer) {
            observers.Remove(observer);
        }
        public void Notify() {
            foreach(Observer observer in observers)
                observer.Update(State);
        }
    }
    class ConcreteSubject:Subject {
        public override string State { get; set; }
    }
    public abstract class Observer {
        public abstract void Update(string State);
    }
    class ConcreteObserver:Observer {
        string observerState;
        ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject) {
            this.subject = subject;
        }
        public override void Update(string state) {
            observerState = state;
            Console.WriteLine(this.observerState + GetHashCode());
        }
    }

    class Program {
        static void Main(string[] args) {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));
            subject.State = "Some State... ";
            subject.Notify();
        }
    }
}
