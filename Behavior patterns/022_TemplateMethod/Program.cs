using System;
using _022_TemplateMethod.Patterns;
namespace _022_TemplateMethod {
    class Program {
        static void Main(string[] args) {
            ConsoleColor color = Console.BackgroundColor;
            AbsFlag flag = new Ukrain();

            flag.Draw();
            Console.WriteLine();

            flag = new PolandFlag();
            flag.Draw();

            Console.BackgroundColor = color;

        }
    }
}
