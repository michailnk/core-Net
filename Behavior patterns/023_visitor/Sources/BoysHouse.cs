using System;

namespace _023_visitor.Sources {
    public class BoysHouse {
        internal void TellFairyTale() {
            Console.WriteLine("Fairy Tale...");
        }

        public  void Accept(Visitor visitor) {
            visitor.VisitorBoysHouse(this);
        }
    }
}