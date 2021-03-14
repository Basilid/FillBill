using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using ReactiveUI.Fody.Helpers;

namespace Demo
{
    public class Package
    {
        public PackageStatus Status { get; set; }

        [Reactive]
        public string Number { get; set; }

        [Reactive]
        public string Comment { get; set; }

        public string SMGSNum => Docs.OfType<SMGS>()
            .Select(s => s.Number)
            .FirstOrDefault();

        [Reactive]
        public ObservableCollection<Doc> Docs { get; set; } = new ObservableCollection<Doc>();
    }

}