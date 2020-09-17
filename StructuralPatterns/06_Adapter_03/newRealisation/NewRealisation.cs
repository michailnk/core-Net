using System;

namespace _06_Adapter_03{
    class NewRealisation : INewInterface {
        public void MethodNew() {
            Console.WriteLine("new method");
        }
    }
}
