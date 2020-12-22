using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_visitor.Sources
{
    public class Santa: Visitor
    {
        public override void VisitorBoysHouse(BoysHouse boysHouse) {
            boysHouse.TellFairyTale();
        }

        public override void VisitorGirlsHousе(GirlsHouse girlsHouse) {
            girlsHouse.GiveDress();
        }
    }
}
