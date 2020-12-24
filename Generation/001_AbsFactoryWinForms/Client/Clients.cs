using _001_AbsFactoryWinForms.Buttons;
using _001_AbsFactoryWinForms.Factories;
using _001_AbsFactoryWinForms.Windows;
using System.Windows.Forms;

namespace _001_AbsFactoryWinForms.Client {
    public class Clients {
        AbsButton button;
        AbsWindow window;

        public Clients(AbsFactory factories) {
            window = factories.CreateWindow();
            button = factories.CreateButton();
        }

        public Form GetForm() {
            window.AddTooCollection(button);
            return window;
        }
    }
}
