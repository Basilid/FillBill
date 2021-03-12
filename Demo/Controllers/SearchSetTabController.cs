using System.Windows.Controls;
using PropertyChanged;

namespace Demo
{
    [AddINotifyPropertyChangedInterface]
    public class SearchSetTabController : TabController<SearchSet>
    {
        public Package SelectedPackage { get; set; }
    }
}