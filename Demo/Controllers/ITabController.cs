using System.Windows.Controls;

namespace Demo
{
    public interface ITabController<T>
    {
        T Model { get; set; }
        TabItem TabItem { get; set; }
    }
}