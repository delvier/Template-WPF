using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CommonServiceLocator.NinjectAdapter;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Ninject;

namespace TemplateProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel kernel;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            kernel = new StandardKernel();
            var provider = new NinjectServiceLocator(kernel);

            ServiceLocator.SetLocatorProvider(() => provider);

            this.KernelBinds(); // initalize bind interface to class.

            Current.MainWindow = this.kernel.Get<MainWindow>();
            Current.MainWindow.Show();
        }

        private void KernelBinds()
        {
            kernel.Bind<EventAggregator>().ToSelf().InSingletonScope();
            //kernel.Bind<Resources>().ToSelf().InSingletonScope();
        }
    }
}
