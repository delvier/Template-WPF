using System.Windows;
using Microsoft.Practices.Prism.Events;
using Ninject;
using Ninject.Extensions.Factory;
using TemplateProject.ViewModels;
using EngineModuleProject;


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

            _kernel = new StandardKernel( 
                    new EngineModule()
                );

            // factory exampale
            _kernel.Bind<IBarFactory>().ToFactory();

            _kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            _kernel.Bind<IMainViewModel>().To<MainViewModel>().InSingletonScope();
            
            
            Current.MainWindow = this._kernel.Get<MainWindow>();
            Current.MainWindow.Show();
        }
    }
}
