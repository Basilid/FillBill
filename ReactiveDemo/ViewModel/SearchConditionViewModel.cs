using ReactiveUI.Fody.Helpers;

namespace ReactiveDemo
{
    public class SearchConditionViewModel : BaseViewModel
    {
        [Reactive]
        public bool IsFixed { get; set; }
        [Reactive]
        public bool IsActive { get; set; }
        [Reactive]
        public string FieldName { get; set; }
        [Reactive]
        public string Pattern { get; set; }
    }
}