using _001_AbsFactoryWinForms.Buttons;
using _001_AbsFactoryWinForms.Windows;
using System.Drawing;

namespace _001_AbsFactoryWinForms.Factories
{
    public class WindowsForm : AbsWindow {
        public override void AddTooCollection(AbsButton button) {
            this.Controls.Add(button);
        }

        public WindowsForm() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            Name = "windowsForm";
            Text = "Windows";
            BackColor = Color.Blue;
        }
    }
}
