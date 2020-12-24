using System.Drawing;

namespace _001_AbsFactoryWinForms.Buttons {
    public class WinButton :AbsButton
    {
        public WinButton() {
            ForeColor = Color.FromArgb(0, 0, 0);
            BackColor = Color.FromArgb(100, 170, 230);
            Text = "Win Ntfs";
        }
        
    }
}
