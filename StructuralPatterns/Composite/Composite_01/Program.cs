using System;
using System.Collections;

namespace Composite_01 {
    class Program {
        static void Main(string[] args) {
            Component root = new Composite("root");
            Component branch1 = new Composite("branch1");
            Component branch2 = new Composite("branch2");
            Component leaf1 = new Leaf("L1");
            Component leaf2 = new Leaf("L2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);
            root.Operation();
        }
    }

    abstract class Component {
        protected string name;
        public Component(string name) => this.name = name;
        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChaild(int index);
    }

    class Composite:Component {
        ArrayList nodes = new ArrayList();
        public Composite(string name) : base(name) { }
        public override void Add(Component component) =>
            nodes.Add(component);
        public override Component GetChaild(int index) =>
            nodes[index] as Component;

        public override void Remove(Component component) =>
            nodes.Remove(component);
        public override void Operation() {
            Console.WriteLine(name);
            foreach(Component item in nodes)
                item.Operation();
        }
    }

    class Leaf:Component {

        public Leaf(string name) : base(name) { }
        public override void Operation() {
            Console.WriteLine(name);
        }
        public override void Add(Component component) {
            throw new InvalidOperationException();
        }

        public override Component GetChaild(int index) {
            throw new InvalidOperationException();
        }


        public override void Remove(Component component) {
            throw new InvalidOperationException();
        }
    }
}
