using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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
using ReactiveUI;
using Splat;

namespace ReactiveDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var tabItem = new TabItem
            {
                Content = new SearchSetView()
            };
            var indexTabItem = MainTabControl.Items.IndexOf(sender);
            MainTabControl.Items.Insert(indexTabItem, tabItem);
            //MainTabControl.SelectedItem = tabItem;
            Dispatcher.BeginInvoke((Action)(() => MainTabControl.SelectedIndex = indexTabItem));
        }
    }
}
