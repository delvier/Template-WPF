﻿using System.Windows;
using Ninject;
using Ninject.Extensions.Factory;
using TemplateProject.Infrastructure;
using EngineModuleProject;
using Microsoft.Practices.Prism.PubSubEvents;


namespace TemplateProject
{
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

            // domain 
            _kernel.Bind<ITestRepository>().To<TestRepository>();
            _kernel.Bind<MainWindow>().ToSelf();
            
            Current.MainWindow = _kernel.Get<MainWindow>();
            Current.MainWindow.Show();
        }
    }
}
