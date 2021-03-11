using System.Windows;
using System.Windows.Controls;

namespace Demo
{
    public class TabControlTitled: TabControl
    {
        public static readonly DependencyProperty LeftTitleProperty = DependencyProperty.Register(
            "LeftTitle", typeof(object), typeof(TabControlTitled), new PropertyMetadata(default(object)));


        public object LeftTitle
        {
            get => GetValue(LeftTitleProperty);
            set => SetValue(LeftTitleProperty, value);
        }

        public static readonly DependencyProperty RightTitleProperty = DependencyProperty.Register(
            "RightTitle", typeof(object), typeof(TabControlTitled), new PropertyMetadata(default(object)));

        public object RightTitle
        {
            get => GetValue(RightTitleProperty);
            set => SetValue(RightTitleProperty, value);
        }
    }
}