using System.Windows.Controls;
using System;
using ReactiveUI.Fody.Helpers;

namespace Demo
{
    public abstract class TabController<T> : ITabController<T>
    {
        [Reactive]
        public virtual T Model { get; set; }

        [Reactive]
        public virtual TabItem TabItem { get; set; }
    }

    public static class TabController
    {
        private static class TabControllerFactory<TBase>
        {
            public static Type ImplementationType;                        
        }

        public static TabController<TBase> Create<TBase>(TabItem tabItem, TBase content)
            where TBase: class
        {
            var res = (TabController<TBase>)Activator.CreateInstance(TabControllerFactory<TBase>.ImplementationType);
            res.TabItem = tabItem;
            res.Model = content;
            return res;
        }

        public static void RegisterFactory<TBase,TImp>()
            where TImp: TabController<TBase>
        {
            TabControllerFactory<TBase>.ImplementationType = typeof(TImp);
        }

        public static bool IsRegistered<TBase>()
        {
            return TabControllerFactory<TBase>.ImplementationType != null;
        }
    }
}