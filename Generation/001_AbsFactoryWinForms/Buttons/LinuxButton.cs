using System.Drawing;

namespace _001_AbsFactoryWinForms.Buttons {
    public class LinuxButton:AbsButton
    {
        public LinuxButton() {
            Text = "Linux";
            ForeColor = Color.FromArgb( 0, 0, 0);
            BackColor = Color.FromArgb(240, 170, 70);
        }
        
    }
}
