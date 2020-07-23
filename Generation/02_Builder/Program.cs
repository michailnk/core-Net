using System;
using System.Collections;

namespace _02_Builder {
    internal class House {
        ArrayList parts = new ArrayList();
        internal void Show() {
            foreach (var item in parts) {
                Console.WriteLine( $" It's {item.GetType().Name}");
            }
        }
        internal void Add(object part) {
            parts.Add(part);
        }
    }

    internal class Directory {
        public Builder Builder { get; }
        public Directory(Builder builder) {
            Builder = builder;
        }
        internal void Construct() {
            Builder.BuildBasement();
            Builder.BuildStorey();
            Builder.BuildRoof();
        }
    }
    internal class ConcreteBuilder : Builder {
        House house = new House();
        public override void BuildBasement() {
            house.Add(new Basement());
        }
        public override void BuildRoof() {
            house.Add(new Roof());
        }
        public override void BuildStorey() {
            house.Add(new Storey());
        }
        public override House GetResult() {
            return house;
        }
    }

    internal class Storey {
        public Storey() {
            Console.WriteLine(" Storey is had built");
        }
    }
    internal class Basement {
        public Basement() {
            Console.WriteLine(" Basement is had basement");
        }
    }
        internal class Roof {
        public Roof() {
            Console.WriteLine(" Roof is had roof");
        }
    }

        internal abstract class Builder {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House GetResult();
    }
    class Program {
        static void Main(string[] args) {
            Builder builder = new ConcreteBuilder();
            Directory directory = new Directory(builder);
            directory.Construct();
            House product = builder.GetResult();
            Console.WriteLine(new string('_',30));
            product.Show();
        }
    }
}
