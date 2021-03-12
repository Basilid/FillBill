using System.Windows.Controls;
using PropertyChanged;
using System;

namespace Demo
{
    [AddINotifyPropertyChangedInterface]
    public abstract class TabController<T> : ITabController<T>
    {
        public T Model { get; set; }
        public TabItem TabItem { get; set; }
    }

    public static class TabController
    {
        private static class TabControllerFactory<Tbase>
        {
            public static Type ImplementationType;                        
        }

        public static TabController<Tbase> Create<Tbase>()
            where Tbase: class
        {
            var res = (TabController<Tbase>)Activator.CreateInstance(TabControllerFactory<Tbase>.ImplementationType);
            return res;
        }

        public static void RegisterFactory<Tbase,Timp>()
            where Timp: TabController<Tbase>
        {
            TabControllerFactory<Tbase>.ImplementationType = typeof(Timp);
        }

        public static bool IsRegistered<Tbase>()
        {
            return TabControllerFactory<Tbase>.ImplementationType != null;
        }
    }
}