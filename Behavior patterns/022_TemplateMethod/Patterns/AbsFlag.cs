using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_TemplateMethod.Patterns
{
    public abstract class AbsFlag
    {

        public void Draw() {
            DrawTopPart();
            DrawBottomPart();
        }
        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
    }
}
