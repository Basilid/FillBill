using ReactiveUI.Fody.Helpers;

namespace ReactiveDemo
{
    public class SearchSetViewModel : BaseViewModel
    {
        [Reactive]
        public string Name { get; set; }
    }
}