using System.Windows;
using System.Windows.Controls;

namespace Demo
{
    public class TabControlTitled: TabControl
    {
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title", typeof(string), typeof(TabControlTitled), new PropertyMetadata(default(string)));

        public string Title
        {
            get => (string) GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
    }
}