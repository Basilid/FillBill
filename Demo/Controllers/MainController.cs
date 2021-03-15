using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;


namespace Demo
{
    
    public class MainController
    {
        public ICommand DeleteSearchConditionCommand = new RoutedCommand("DeleteSearchCondition", typeof(MainController));

        public MainWindow MainWindow { get; set; }

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
        public MainController()
        {
            TabController.RegisterFactory<Package, PackageTabController>();
            TabController.RegisterFactory<SearchSet, SearchSetTabController>();
        }

        public void Show()
        {
            ShowObjectInMainTabs(SearchSet);
        }

        public Dictionary<object, ITabController<object>> MainTabControllers { get; set; }
            = new Dictionary<object, ITabController<object>>();

        public void ShowObjectInMainTabs<T>(T obj)
            where T : class
        {
            AddTabController(obj);
            MainWindow.MainTabControl.Items.Add(MainTabControllers[obj].TabItem);
        }

        private void AddTabController<T>(T obj)
            where T : class
        {
            if (TabController.IsRegistered<T>())
            {
                var tabController = (ITabController<object>)TabController.Create<T>(new TabItem(), obj);
                MainTabControllers.Add(obj, tabController);
            }
        }
    }
}