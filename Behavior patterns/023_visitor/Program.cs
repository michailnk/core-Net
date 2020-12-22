using System;
using _023_visitor.Sources;

namespace _023_visitor {
    class Program {
        static void Main(string[] args) {

            Visitor santa = new Santa();
            santa.VisitorBoysHouse(new BoysHouse());

            santa.VisitorGirlsHousе(new GirlsHouse());

        }
    }
}
