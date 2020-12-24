using System;
using System.Windows.Forms;
using _001_AbsFactoryWinForms.Factories;
using _001_AbsFactoryWinForms.Client;

namespace _001_AbsFactoryWinForms {
    static class Program {

        [STAThread]
        static void Main() {

           Clients client = null;

            //client = new Clients(new LinuxFactory());
            client = new Clients(new WindowFactory());


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(client.GetForm());
        }
    }
}
