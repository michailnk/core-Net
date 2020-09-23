using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bridge_02_Shape_.Implementator {
    class DotLine:LineStyle {
        public override Pen Draw(Color color) {
            Pen pen = new Pen(color, 6);
            pen.DashStyle = DashStyle.Dash;
            return pen;
        }
    }
}
