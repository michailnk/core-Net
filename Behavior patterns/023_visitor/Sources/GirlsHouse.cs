using System;

namespace _023_visitor.Sources {
    public class GirlsHouse {
        internal void GiveDress() {
            Console.WriteLine("Dress as a gift.");
        }

        public void VisitorGirlsHousе(Visitor visitor) {
            visitor.VisitorGirlsHousе(this);
        }
    }
}