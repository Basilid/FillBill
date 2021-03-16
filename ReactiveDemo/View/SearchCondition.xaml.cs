using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;

namespace ReactiveDemo
{
    /// <summary>
    /// Interaction logic for SearchCondition.xaml
    /// </summary>
    public partial class SearchConditionView : ReactiveUserControl<SearchConditionViewModel>
    {
        public SearchConditionView()
        {
            InitializeComponent();
            ViewModel = new SearchConditionViewModel();

            this.WhenActivated(disp =>
            {
                this.Bind(ViewModel,
                    vmProperty => vmProperty.IsActive, 
                    view => view.cbIsActive.IsChecked)
                    .DisposeWith(disp);

                this.BindCommand(ViewModel, 
                    vm => vm.RemoveConditionCommand, 
                    v => v.bRemove)
                    .DisposeWith(disp);
            });
        }
    }
}
