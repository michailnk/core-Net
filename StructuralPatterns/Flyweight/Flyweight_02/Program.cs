using System;
/*
 * здесь применяется Flyweight
 * string a = "hello";
 * string b = "hello";
 */
namespace Flyweight_02 {
    class Program {
        static void Main(string[] args) {
        string[] array = new string[1024];
            // create new line 1024^2*2(byte in Unicode)

            for(int i = 0;i < array.Length; i++) {
                // unshared Concrete Flyweight
                //array[i] = new string('-', (int)Math.Pow(1024, 2)); // на console core нет проблем на netFrameworke System.OutOfMemoryException
                //concrete flyweight
                //array[i] = string.Intern(new string('-', (int)Math.Pow(1024, 2))+i.ToString());
                array[i] = string.Intern(new string('-', (int)Math.Pow(1024, 2)));

                Console.WriteLine(GC.GetTotalMemory(false)/ (int)Math.Pow(1024,2)+ " MB");

            }
            
            Console.ReadKey();
        }
    }
}
