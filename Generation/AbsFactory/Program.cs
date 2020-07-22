using System;
namespace AbsFactory {
    abstract class AbsFactory {
        public abstract AbsWater CreateWater();
        public abstract AbsBottle CreatBottle();
    }
    abstract class AbsBottle { public abstract void Interact(AbsWater water); }
    abstract class AbsWater {
    }
    class ColaFactory : AbsFactory {
        public override AbsBottle CreatBottle() {
            return new ColaBottle();
        }
        public override AbsWater CreateWater() {
            return new ColaWater();
        }
    }
    class ColaWater : AbsWater {
    }
    class ColaBottle : AbsBottle {
        public override void Interact(AbsWater water) {
            Console.WriteLine(this.GetType().Name + " add " + water.GetType().Name);
        }
    }
    class PepsiFactory : AbsFactory {
        public override AbsBottle CreatBottle() {
            return new PepsiBottle();
        }
        public override AbsWater CreateWater() {
            return new PepsiWater();
        }
    }
    class PepsiWater : AbsWater {
    }
    class PepsiBottle : AbsBottle {
        public override void Interact(AbsWater water) {
            Console.WriteLine(this.GetType().Name + " add " + water.GetType().Name);
        }
    }
    class Client {
        private AbsBottle bottle;
        private AbsWater water;
        public Client(AbsFactory factory) {
            bottle = factory.CreatBottle();
            water = factory.CreateWater();
        }
        public void Run() {
            bottle.Interact(water);
        }
    }
    class Program {
        static void Main(string[] args) {
            Client client = null;
            client = new Client(new ColaFactory());
            client.Run();
            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}
