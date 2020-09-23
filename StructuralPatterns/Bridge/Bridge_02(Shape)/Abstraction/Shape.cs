﻿using Bridge_02_Shape_.Implementator;
using System.Drawing;
using System.Windows.Forms;
namespace Bridge_02_Shape_.Abstraction {
    abstract  class Shape {
        protected Graphics graphics = null;
        protected Pen pen = null;

        public LineStyle implementor = null;

        public virtual void Draw(Form form, Color color) {
            this.graphics = form.CreateGraphics();
            this.pen = implementor.Draw(color);
        }
    }
}
