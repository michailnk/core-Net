using System;

namespace _17_Mediator_01 {

    abstract class Mediator {
        public abstract void Send(string msg, Colleague colleague);
    }
    class ConcreteMediator:Mediator {
        public Farmer Farmer { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }
        public override void Send(string msg, Colleague colleague) {
            if(colleague == Farmer)
                Cannery.MakeKetchup(message);
            else if(colleague == Cannery)
                Shop.SellKetchup(msg);
        }

    public class Shop {
    }

    public class Cannery {
    }

    abstract class Colleague {
        protected Mediator mediator;

        protected Colleague(Mediator mediator) {
            this.mediator = mediator;
        }
    }
    class Farmer:Colleague {
        public Farmer(Mediator m) : base(m) { }
        public void GrowTomato() {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name + " raised" + tomato);
            mediator.Send(tomato, this);
        }
    }



    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
}
