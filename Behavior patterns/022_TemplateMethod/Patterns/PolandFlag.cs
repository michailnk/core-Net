using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_TemplateMethod.Patterns
{
    public class PolandFlag : AbsFlag {
        protected override void DrawBottomPart() {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrawTopPart() {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ', 7));
        }
    }
}
