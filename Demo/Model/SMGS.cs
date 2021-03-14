using System;
using ReactiveUI.Fody.Helpers;

namespace Demo
{
    public class SMGS: Doc
    {
        [Reactive]
        public string Number { get; set; }

        [Reactive]
        public DateTime DateTime { get; set; }
    }
}