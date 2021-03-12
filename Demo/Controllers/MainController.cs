using System.Collections.Generic;
using System.Windows.Input;
using PropertyChanged;

namespace Demo
{
    [AddINotifyPropertyChangedInterface]
    public class MainController
    {
        public ICommand DeleteSearchConditionCommand = new RoutedCommand("DeleteSearchCondition", typeof(MainController));

        public MainController()
        {
            TabController.RegisterFactory<Package, PackageTabController>();
            TabController.RegisterFactory<SearchSet, SearchSetTabController>();
        }

        public HashSet<ITabController<object>> MainTabControllers { get; set; }

        public void ShowObjectInMainTabs<T>(T obj)
            where T : class
        {
            AddTabController(obj);
            //ToDo Showing Tab
        }

        private void AddTabController<T>(T obj)
            where T : class
        {
            if (TabController.IsRegistered<T>())
            {
                MainTabControllers.Add((ITabController<object>)TabController.Create<T>());
            }
        }
    }
}