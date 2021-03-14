using ReactiveUI.Fody.Helpers;

namespace Demo
{
    public class SearchCondition
    {
        [Reactive]
        public bool IsActive { get; set; } = true;
        [Reactive]
        public string FieldName { get; set; }
        [Reactive]
        public string Pattern { get; set; }
        [Reactive]
        public bool IsFixed { get; set; }
    }
}