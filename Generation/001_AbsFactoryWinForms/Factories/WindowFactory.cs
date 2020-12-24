using _001_AbsFactoryWinForms.Buttons;
using _001_AbsFactoryWinForms.Windows;

namespace _001_AbsFactoryWinForms.Factories
{
    public class WindowFactory : AbsFactory {
        public override AbsButton CreateButton() {
            return new WinButton();
        }

        public override AbsWindow CreateWindow() {
            return new WindowsForm();
        }
    }
}
