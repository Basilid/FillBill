using System;
using System.Collections.Generic;
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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Binding Commands

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void CommandBinding_Executed_2(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
        }

        private void CommandBinding_Executed_3(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        #endregion

        public SearchSet SearchSet = new SearchSet
        {
            Conditions = { new SearchCondition
                {
                    FieldName = "Номер СМГС",
                    Pattern = "345345345",
                    IsFixed = true
                },
                new SearchCondition
                {
                    FieldName = "Станция приёма",
                    Pattern = "ПЕЧОРЫ",
                }
            },
            Result = { new Package
            {
                Number = "PK-111",
                Status = PackageStatus.Forming,
                Docs = { new SMGS { Number = "C456456456"} }
            },
                new Package
                {
                    Number = "PK-222",
                    Status = PackageStatus.Forming,
                    Docs = { new SMGS { Number = "C456456456"} }
                },

            }
        };

        public MainWindow()
        {
            InitializeComponent();
            InitTreeViewData();
            SearchTab1.Content = SearchSet;
        }

        private void InitTreeViewData()
        {
            TreeView1.ItemsSource = SearchSet.Result;
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            SearchSet.Conditions.Add(new SearchCondition());
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            SearchSet.Conditions.Remove((SearchCondition)((Button)sender).Tag);
        }

        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void TabItem_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (!(e.Source is TabItem tabItem))
            {
                return;
            }

            if (Mouse.PrimaryDevice.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(tabItem, tabItem, DragDropEffects.All);
            }
        }

        private void TabItem_Drop(object sender, DragEventArgs e)
        {
            if (e.Source is TabItem tabItemTarget &&
                e.Data.GetData(typeof(TabItem)) is TabItem tabItemSource &&
                !tabItemTarget.Equals(tabItemSource) &&
                tabItemTarget.Parent is TabControl tabControl)
            {
                int targetIndex = tabControl.Items.IndexOf(tabItemTarget);

                tabControl.Items.Remove(tabItemSource);
                tabControl.Items.Insert(targetIndex, tabItemSource);
                tabItemSource.IsSelected = true;
            }
        }
    }
}
