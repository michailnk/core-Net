using System;
/// <summary>
///  this is the basic pattern for generating templates. Its task is to describe not only
///  the generation of objects, but also to describe the interactions between the base and 
///  the derived. This is a fundamental pattern.
///  Its main purpose is to be the basis for the other 4 generative patterns
/// </summary>
namespace Factory_Method {

    abstract class Product { }
    abstract class Creator {
        Product product;
        public abstract Product FactoryMethod();
        public void AnOnperation() {
            product = FactoryMethod();
        }
    }

    class ConcretProduct : Product {
        public ConcretProduct() {
            Console.WriteLine(this.GetHashCode());
        }
    }
    class ConcreteCreator : Creator {
        public override Product FactoryMethod() {
            return new ConcretProduct();
        }
    }

    class Program {
        static void Main(string[] args) {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOnperation();
        }
    }
}
