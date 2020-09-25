using System;

namespace Decorator_02 {
    class Program {
        static void Main(string[] args) {
            Pizza italianCheese = new CheesePizza(new ItalianPiazza());
            Console.WriteLine($"{((PizzaDecorator)italianCheese).AboutMyself()} {italianCheese.GetCost()}");
            Pizza musshroom = new MushroomsPizza(new BulgerianPizza());
            Console.WriteLine(musshroom.Name +" " + musshroom.GetCost());
        }
    }

    abstract class Pizza {
        public string Name { protected set; get; }
        public abstract double GetCost();

        protected Pizza(string name) {
            Name = name;
        }
    }

    class BulgerianPizza:Pizza {
        public override double GetCost() => 4.5;
        public BulgerianPizza() :base("Bulgarian") {}
    }
    class ItalianPiazza:Pizza {
        public override double GetCost() =>5.4;
        public ItalianPiazza() : base("italian") { }
    }

    abstract class PizzaDecorator:Pizza {
        protected Pizza pizza;

        public virtual string AboutMyself() {
            return pizza.Name;
        }
        protected PizzaDecorator(string n, Pizza pizza) : base(n) {
            this.pizza = pizza;
        }
    }

    class CheesePizza:PizzaDecorator {
        public CheesePizza(Pizza p) : base(p.Name, p) { }
        public override double GetCost() {

            return pizza.GetCost() + 2;
        }
        public override string AboutMyself() {
           return base.AboutMyself() + ", with a cheese $ ";     
        }
    }

    class MushroomsPizza : PizzaDecorator{
        public MushroomsPizza(Pizza p): base(p.Name +", add mushrooms $ ", p) { }
        public override double GetCost() {

            return pizza.GetCost() + 1.7;
        }
    }
}
