using System.Windows;
using Microsoft.Practices.Prism.Events;
using Ninject;
using Ninject.Extensions.Factory;
using TemplateProject.ViewModels;


namespace TemplateProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel _kernel;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _kernel = new StandardKernel();
            _kernel.Bind<IBarFactory>().ToFactory();
            //kernel = new StandardKernel(new Object(), new Object()); modules inside.
            
            //binds to interfaces.
            _kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            _kernel.Bind<IMainViewModel>().To<MainViewModel>().InSingletonScope();
            
            
            Current.MainWindow = this._kernel.Get<MainWindow>();
            Current.MainWindow.Show();
        }
    }
}
