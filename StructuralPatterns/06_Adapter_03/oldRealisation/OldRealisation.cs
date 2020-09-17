using System;

namespace _06_Adapter_03 {
    class OldRealisation : IOldInterface {
        public void OldMethod() {
            Console.WriteLine("old method");
        }
    }
}
