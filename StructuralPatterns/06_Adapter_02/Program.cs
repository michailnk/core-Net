using System;
// object level adapter

namespace _06_Adapter_02 {
    abstract class Target {
        public abstract void Request();
    }
    class Adapter : Target {
        Adaptee adaptee = new Adaptee();
        public override void Request() {
            adaptee.SpecialRequest();
        }
    }

     class Adaptee {
        public void SpecialRequest() { }
    }

    class Client {
        static void Main(string[] args) {
            Target target = new Adapter();
            target.Request();
        }
    }
}
