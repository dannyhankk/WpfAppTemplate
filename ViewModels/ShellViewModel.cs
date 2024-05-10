using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Provider;

namespace WpfAppTemplate.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {

        public ShellViewModel() { }
        public Task EditCategories()
        {
            var viewModel = IoC.Get<TemplateCategoryViewModel>();
            return ActivateItemAsync(viewModel, new CancellationToken());
        }

        protected async override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await EditCategories();
        }
    }
}
