using System;
//interaction interface 
//televic dev express 
// the adapter is level class. It's no optimate variable

namespace _06_Adapter_01 {
    interface ITarget {
        void Request();
    }
    class Adaptee {
        public void SpecificRequest() { }
    }

    class Adapter : Adaptee, ITarget {
        public void Request() {
            base.SpecificRequest();
        }
    }

    class Clint {
        static void Main(string[] args) {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
