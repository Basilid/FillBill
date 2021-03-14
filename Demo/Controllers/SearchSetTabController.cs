using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using ReactiveUI.Fody.Helpers;

namespace Demo
{
    
    public class SearchSetTabController : TabController<SearchSet>
    {
        [Reactive]
        public Package SelectedPackage { get; set; }

        [Reactive]
        public override TabItem TabItem
        {
            get => base.TabItem;
            set
            {
                if (base.TabItem != value)
                {
                    base.TabItem = value;
                    var commandBinding = new CommandBinding(ApplicationCommands.Delete, Executed);
                    TabItem.CommandBindings.Add(commandBinding);
                    var tabHeadFace = new StackPanel { Orientation = Orientation.Horizontal };
                    tabHeadFace.Children.Add(new Image { Height = 16, Source = new BitmapImage(
                        new Uri(AppDomain.CurrentDomain.BaseDirectory+@"Images\search.png", UriKind.Absolute)) });
                    TabItem.Header = tabHeadFace;
                }
            }
        }

        private void Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (((Button)e.OriginalSource).Tag is SearchSet searchSet)
            {
                searchSet.Conditions.Remove((SearchCondition)e.Parameter);
            }
        }
    }
}