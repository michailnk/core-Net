using System;

namespace Bridge_03 {
    class Program {
        static void Main(string[] args) {
            Car car = new Sedan(new Skoda());
            car.PrintMark();
            car = new Hatchback(new Kia());
            car.PrintMark();
        }
    }

    abstract class Car {
        protected Marke marke;
        protected Car(Marke marke) {
            this.marke = marke;
        }
        public abstract void PrintMark();
    }
    class Sedan:Car {
        public Sedan(Marke marke) : base(marke) {  }
        public override void PrintMark() {
            marke.SetMarke(this);
        }
    }
    class Hatchback:Car {
        public Hatchback(Marke marke) : base(marke) { }
        public override void PrintMark() {
            marke.SetMarke(this);
        }
    }
    interface Marke {
        void SetMarke(Car body);
    }

    class Skoda:Marke {
        public void SetMarke(Car body) {
            Console.WriteLine("This is Skoda - "+ body.GetType().Name);
        }
    }
    class Kia:Marke {
        public void SetMarke(Car body) {
            Console.WriteLine("This is Kia - "+body.GetType().Name);
        }
    }
}
