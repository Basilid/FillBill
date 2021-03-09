using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtualList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Game> Games { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadListGames();
        }

        private void LoadListGames()
        {
            Games = File.ReadAllLines(@"D:\games3.txt")
                .Select(s =>
                {
                    var ss = s.Split(';');
                    return new Game { Name = ss[0], LogoURL = ss[1]};
                }).ToList();
        }
    }
}
