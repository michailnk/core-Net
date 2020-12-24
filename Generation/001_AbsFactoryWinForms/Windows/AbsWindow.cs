using _001_AbsFactoryWinForms.Buttons;
using System.Drawing;
using System.Windows.Forms;

namespace _001_AbsFactoryWinForms.Windows {
    public abstract class AbsWindow : Form {
        public abstract void AddTooCollection(AbsButton button);
        public AbsWindow() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 172);
        }
    }
}
