
using _001_AbsFactoryWinForms.Buttons;
using System.Drawing;

namespace _001_AbsFactoryWinForms.Windows
{
    public class LinuxForm : AbsWindow {
        public override void AddTooCollection(AbsButton button) {
            this.Controls.Add(button);
        }

        public LinuxForm() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            Name = "linuxForm";
            Text = "Linux";
            BackColor = Color.White;
        }
    }
}
