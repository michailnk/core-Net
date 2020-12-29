using System.Windows.Forms;

namespace _002_FM_formSubClass {
    class SubTextBox : TextBox {
        private const int WM_CHAR = 0x102;
        protected override void WndProc(ref Message m) {
            // ЕСЛИ: Нажата клавиша CTRL.
            if (SubTextBox.ModifierKeys.CompareTo(Keys.Control) == 0) {
                switch (m.Msg) {
                    case WM_CHAR: {
                            // Запрещение CTRL+X.
                            switch (m.WParam.ToInt32()) {
                                case 24: // X = 24-й символ алфавита.
                                    {
                                        // Ничего не делать, чтобы игнорировать 
                                        // обработку нажатия клавиши - Х.
                                        break;
                                    }

                                case 22: break;  //  запрет на  Ctrl+V

                                default: {
                                        base.WndProc(ref m);
                                        break;
                                    }
                            }
                            break;
                        }
                    default: {
                            base.WndProc(ref m);
                            break;
                        }
                }
            }
            else {
                // Убедитесь, что Вы передаете необработанные сообщения 
                // обратно в обработчик сообщений по умолчанию.
                base.WndProc(ref m);
            }
        }
    }
}
