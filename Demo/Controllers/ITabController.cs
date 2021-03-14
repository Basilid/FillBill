using System.Windows.Controls;

namespace Demo
{
    public interface ITabController<out T>
    {
        T Model { get; }
        TabItem TabItem { get; set; }
    }
}