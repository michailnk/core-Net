
using System;

namespace Bridge_01 {

    abstract class Abstraction {
        protected Implementor implementor;
        public Abstraction(Implementor implementor) {
            this.implementor = implementor;
        }
        public virtual void Operatiron() {
            implementor.OperationImp();
        }
    }

    class RefineAbstraction:Abstraction {
        public RefineAbstraction(Implementor implementor) : base(implementor) {
        }
        public override void Operatiron() {
            base.Operatiron();
            Console.WriteLine("Add operation " + implementor.GetType().Name);
        }
    }

    abstract class Implementor {
        public abstract void OperationImp();
    }

    class ConcreteImplementorA:Implementor {
        public override void OperationImp() {
            Console.WriteLine("Implementor A");
        }
    }
    class ConcreteImplementorB:Implementor {
        public override void OperationImp() {
            Console.WriteLine("Implementor B");
        }
    }

    class Program {
        static void Main(string[] args) {
            Abstraction abstraction;
            abstraction = new RefineAbstraction(new ConcreteImplementorA());
            abstraction.Operatiron();

            abstraction = new RefineAbstraction(new ConcreteImplementorB());
            abstraction.Operatiron();
        }
    }
}

