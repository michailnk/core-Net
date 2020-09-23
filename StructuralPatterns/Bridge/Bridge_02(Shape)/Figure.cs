using Bridge_02_Shape_.Abstraction;
using Bridge_02_Shape_.Implementator;
using System.Drawing;
using System.Windows.Forms;

namespace Bridge_02_Shape_ {
    // Client
    class Figure {
        public static void Draw(Form form, Shape shape, LineStyle line, Color color) {
            shape.implementor = line;
            shape.Draw(form, color);
        }
    }
}
