using System.Windows.Forms;
using System.Drawing;
namespace _001_AbsFactoryWinForms.Buttons
{
    public abstract class AbsButton:Button
    {
        public AbsButton() {
            Text = "Linux";
            Location = new Point(70, 70);
            Size = new Size(120, 30);
        }
    }
}
