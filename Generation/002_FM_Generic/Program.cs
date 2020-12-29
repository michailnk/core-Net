using _002_FM_Generic.Creators;
using _002_FM_Generic.Products;
using System;

namespace _002_FM_Generic {
    class Program {
        static void Main(string[] args) {
            ICreator creator = new Creator();
            IProduct product = null;

            product = creator.CreateProd<ProductA>();
            Console.WriteLine(product);

            product = creator.CreateProd<ProductB>();
            Console.WriteLine(product);

            product = creator.CreateProd<ProductC>();
            Console.WriteLine(product);
        }
    }
}
