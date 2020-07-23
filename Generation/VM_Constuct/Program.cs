using System;

namespace VM_Constuct {

    abstract class Product { }
    class DefProduct : Product { }
    class SpecialProduct : Product { }

    abstract class Creator {
        protected Product product = null;

        protected Creator() {
            product = FactoryMethod();
            //Console.WriteLine(product.GetType().Name);
        }

        public virtual Product FactoryMethod() {
            return new DefProduct();
        }
    }

    class ConcreteCreator : Creator {
        public ConcreteCreator() {
            product = new SpecialProduct();
            //Console.WriteLine(product.GetType().Name);
        }
        public new Product FactoryMethod() {
            return new SpecialProduct();
        }
    }

    class Program {
        static void Main(string[] args) {

            Creator creator = new ConcreteCreator();

            Console.WriteLine( creator.FactoryMethod().GetType().Name);
            Console.WriteLine(((ConcreteCreator)creator).FactoryMethod().GetType().Name);
        }
    }
}
