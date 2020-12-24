using _001_AbsFactoryWinForms.Buttons;
using _001_AbsFactoryWinForms.Windows;

namespace _001_AbsFactoryWinForms.Factories
{
    public class LinuxFactory : AbsFactory {
        public override AbsButton CreateButton() => new LinuxButton();

        public override AbsWindow CreateWindow() => new LinuxForm();
    }
}
