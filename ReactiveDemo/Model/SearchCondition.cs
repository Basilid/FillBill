using System.ComponentModel;
using PropertyChanged;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ReactiveDemo
{
    [AddINotifyPropertyChangedInterface]
    public class SearchCondition
    {
        public bool IsActive { get; set; }
        public string FieldName { get; set; }

        public string Pattern { get; set; }
        public bool IsFixed { get; set; }
    }
}