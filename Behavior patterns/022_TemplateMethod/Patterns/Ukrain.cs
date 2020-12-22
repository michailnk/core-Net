using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_TemplateMethod.Patterns
{
    public class Ukrain : AbsFlag {
        protected override void DrawBottomPart() {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ',7));
        }

        protected override void DrawTopPart() {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 7));
        }
    }
}
