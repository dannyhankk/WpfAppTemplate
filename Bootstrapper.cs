using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using WpfAppTemplate.ViewModels;

namespace WpfAppTemplate
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        { 
            Initialize();
        }
        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            await DisplayRootViewForAsync(typeof(ShellViewModel));
        }
    }
}
