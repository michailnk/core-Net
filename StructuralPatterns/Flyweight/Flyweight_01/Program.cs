using System;
/*
 * здесь применяется Flyweight (если не брать во внимание применяемый низкоуровневый подход)
 * string a = "hello";
 * string b = "hello";
 * Console.Write(ReferencesEquals(a,b)); //true
 */
namespace Flyweight_01 {
    class Program {
        static void Main(string[] args) {
            ActorMikeMyers mike = new ActorMikeMyers();

            RoleAustinPowers austinPowers = new RoleAustinPowers(mike);
            austinPowers.Greeting("Hello! I'm Austin Powers!");

            RoleDoctorEvil doctorEvil = new RoleDoctorEvil(mike);
            doctorEvil.Greeting("Hello! I'm Doctor Evil!");
        }
    }

    abstract class Flyweight {
        public abstract void Greeting(string speeh);
    }

    //inseparable
    class RoleAustinPowers:Flyweight {
        Flyweight flyweight;
        public RoleAustinPowers(Flyweight flyweight) {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speeh) {
            this.flyweight.Greeting(speeh); 
        }
    }
    //inseparable
    class RoleDoctorEvil:Flyweight {
        Flyweight flyweight;

        public RoleDoctorEvil(Flyweight flyweight) {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speeh) {
            this.flyweight.Greeting(speeh);
        }
    }

    //  separable
    class ActorMikeMyers:Flyweight {
        public override void Greeting(string speeh) {
            Console.WriteLine(speeh);
        }
    }
}
