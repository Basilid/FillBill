using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using PropertyChanged;

namespace Demo
{
    [AddINotifyPropertyChangedInterface]
    public class Package
    {
        public PackageStatus Status { get; set; }

        public string Number { get; set; }

        public string SMGSNum => Docs.OfType<SMGS>()
            .Select(s => s.Number)
            .FirstOrDefault();

        public ObservableCollection<Doc> Docs { get; set; } = new ObservableCollection<Doc>();
    }

}