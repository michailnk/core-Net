using System;
using System.Collections.Generic;

namespace _06_Adapter_03 {
    class Program {
        static void Main(string[] args) {
            List<IOldInterface> oldList = new List<IOldInterface>();
            oldList.Add(new OldRealisation());
            oldList.Add(new TwoWayAdapter());
            foreach (var target in oldList)
                target.OldMethod();

            Console.WriteLine(new string('-',20));

            List<INewInterface> newList = new List<INewInterface>();
            newList.Add(new NewRealisation());
            newList.Add(new TwoWayAdapter());
            foreach (var tar in newList)
                tar.MethodNew();

            Console.WriteLine(new string('-',20));

        }
    }
}
