using System;

namespace Facade_01 {
    class Program {
        static void Main(string[] args) {
            Facade facade = new Facade();

            facade.OperationAB();
            facade.OperationBC();
        }
    }

    class Facade {
        SybSystemA sybSystemA = new SybSystemA();
        SybSystemB sybSystemB = new SybSystemB();
        SybSystemC sybSystemC = new SybSystemC();

        public void OperationAB() {
            sybSystemA.OperationA();
            sybSystemB.OperationB();
        }
        public void OperationBC() {
            sybSystemB.OperationB();
            sybSystemC.OperationC();

        }
    }
    internal class SybSystemC {
        public void OperationC() => Console.WriteLine( "Sybsystem C");
    }

    internal class SybSystemB {
        public void OperationB() => Console.WriteLine("Sybsystem B");
    }

    internal class SybSystemA {
        public void OperationA() => Console.WriteLine("Sybsystem A");

    }
}
