using System;

namespace Bridge_03 {
    class Program {
        static void Main(string[] args) {
            Car car = new Sedan(new Skoda());
            car.ShowDatails();
            car = new Hatchback(new Kia());
            car.ShowDatails();
        }
    }

    abstract class Car {
        protected Marke marke;
        protected Car(Marke marke) {
            this.marke = marke;
        }
        public void ShowDatails() {
            Console.Write( GetType().Name);
            PrintMark();
        }
        public abstract void PrintMark();

    }
    class Sedan:Car {
        public Sedan(Marke marke) : base(marke) {  }
        public override void PrintMark() {
            marke.SetMarke();
        }
    }
    class Hatchback:Car {
        public Hatchback(Marke marke) : base(marke) { }
        public override void PrintMark() {
            marke.SetMarke();
        }
    }
    interface Marke {
        void SetMarke();
    }

    class Skoda:Marke {
        public void SetMarke() {
            Console.WriteLine(" Skoda ");
        }
    }
    class Kia:Marke {
        public void SetMarke() {
            Console.WriteLine(" Kia ");
        }
    }
}
