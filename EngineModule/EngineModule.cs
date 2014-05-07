using Ninject.Modules;

namespace EngineModuleProject
{
    public class EngineModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEngine>().To<Engine>();
        }
    }
}
