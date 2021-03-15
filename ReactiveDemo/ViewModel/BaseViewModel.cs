using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace ReactiveDemo
{
    public class BaseViewModel: ReactiveObject, IDisposable
    {
        protected CompositeDisposable CompositeDisposable
            = new CompositeDisposable();

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                CompositeDisposable.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
