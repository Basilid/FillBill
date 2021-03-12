using PropertyChanged;

namespace Demo
{
    [AddINotifyPropertyChangedInterface]
    public class SearchSetViewModel
    {
        public SearchSet SearchSet { get; set; }
        public Package SelectedPackage { get; set; }
    }
}