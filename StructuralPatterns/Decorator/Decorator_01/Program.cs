using System;

namespace Decorator_01 {
    class Program {
        static void Main(string[] args) {
            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;
            decoratorB.Operation();
        }
    }

    abstract class Component { public abstract void Operation(); }

    class ConcreteComponent:Component {
        public override void Operation() {
            Console.WriteLine("ConcreteComponent");
        }
    }
    abstract class Decorator:Component {
        public Component Component { protected get; set; }
        public override void Operation() {
            if(Component != null)
                Component.Operation();
        }
    }

    class ConcreteDecoratorA:Decorator {
        string addState = "Some State";
        public override void Operation() {
            base.Operation();
            Console.WriteLine(addState);
        }
    }

    class ConcreteDecoratorB:Decorator {
        void AddBehavior() {
            Console.WriteLine("Behavior");
        }

        public override void Operation() {
            base.Operation();
            AddBehavior();
        }
    }
}
