using System;
using System.Diagnostics;
using System.Threading;

namespace Prototype_SlowCopy {
    class MyClass : ICloneable {
        int a, b;
        static Random rn = new Random();

        public MyClass() {
            Thread.Sleep(100);
            a = rn.Next(1, 100);
            b = rn.Next(1, 100);
        }

        // error
        object ICloneable.Clone() {
            return new MyClass();
        }

        public object Clone() {
            return this.MemberwiseClone();
        }
        
    }

    class Program {
        static void Main(string[] args) {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MyClass my = new MyClass();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
            stopwatch.Reset();

            stopwatch.Start();
            MyClass m2 = ((ICloneable)my).Clone() as MyClass;
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
            stopwatch.Reset();

            stopwatch.Start();
            MyClass m3 = my.Clone() as MyClass;
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

        }
    }
}
