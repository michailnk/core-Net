using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_visitor.Sources
{
   abstract public class Visitor
    {
        public abstract void VisitorBoysHouse(BoysHouse boysHouse);
        public abstract void VisitorGirlsHousе(GirlsHouse girlsHouse);

    }
}
