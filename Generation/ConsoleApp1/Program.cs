using System;

namespace ConsoleApp1 {

    abstract class Prod { }
    class Phone: Prod {
        public Phone() {
            Console.WriteLine(this.GetHashCode());
        }
    }

    abstract class Creator {
        Prod prod;
        public abstract Prod FactoryMethod();
        public void AnOpaeration() {
            prod = FactoryMethod();
        }
    }

    class PhoneCreator : Creator {
        public override Prod FactoryMethod() {
            return new Phone();
        }
    }

    class Program {
        static void Main(string[] args) {
            Prod prod = null;
            Creator creator = new PhoneCreator();
            prod = creator.FactoryMethod();


        }
    }
}
