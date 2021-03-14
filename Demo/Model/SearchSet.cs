using System.Collections.ObjectModel;
using ReactiveUI.Fody.Helpers;

namespace Demo
{
    public class SearchSet
    {
        [Reactive]
        public string Name { get; set; }

        [Reactive]
        public ObservableCollection<SearchCondition> Conditions { get; } 
            = new ObservableCollection<SearchCondition>();

        [Reactive]
        public ObservableCollection<Package> Result { get; set; } 
            = new ObservableCollection<Package>();
    }
}