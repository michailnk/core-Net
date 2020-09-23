using Bridge_02_Shape_.Abstraction;
using Bridge_02_Shape_.Implementator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_02_Shape_ {
    public partial class Form1:Form {
        public Form1() {
            this.Text = "Bridge";
            this.BackColor = Color.White;
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e) {
            //base.OnPaint(e);
            Figure.Draw(this, new Triangle(), new DotLine(), Color.Aquamarine);
        }
    }
}
