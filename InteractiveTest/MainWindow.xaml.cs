using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InteractiveTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Создание привязки
            CommandBinding bind = new CommandBinding(ApplicationCommands.New);

            // Присоединение обработчика событий
            bind.Executed += NewCommand_Executed;

            // Регистрация привязки
            this.CommandBindings.Add(bind);
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда запущена из " + e.Source.ToString());
        }
    }
}
