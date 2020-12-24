using _001_AbsFactoryWinForms.Buttons;
using _001_AbsFactoryWinForms.Windows;

namespace _001_AbsFactoryWinForms.Factories
{
    public abstract class AbsFactory
    {
        public abstract AbsButton CreateButton();
        public abstract AbsWindow CreateWindow();



    }
}
