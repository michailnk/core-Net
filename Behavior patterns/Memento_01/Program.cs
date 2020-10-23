using System;

namespace Memento_01 {
    
    class Program {
        static void Main(string[] args) {
            Man David = new Man();
            Robot Asimo = new Robot();
            David.Clothes = "Футболка, Джинсы, Кеды";
            Asimo.Backpack = David.Undress();
            David.Clothes = "Шорты";
            David.Dress(Asimo.Backpack);
        }
    }
    // Caretaker
    internal class Robot {
        public Robot() {
        }

        public Backpack Backpack { get; internal set; }
    }
    // Originator
    internal class Man { 
        public string Clothes { get; internal set; }

        internal void Dress(Backpack backpack) {
            Clothes = backpack.Contents;
        }

        internal Backpack Undress() {
            return new Backpack(Clothes);
        }
    }
    // Memento
    class Backpack {
        public string Contents { get; private set; }
        public Backpack(string contnts) {
            this.Contents = contnts;
        }
    }
}
