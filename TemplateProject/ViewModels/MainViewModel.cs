using EngineModuleProject;
namespace TemplateProject.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public string TestLabel { get; set; }
        public string TestModuleLabel { get; set; }

        public MainViewModel(Foo foo, IEngine engine)
        {
            TestLabel = foo.Do(1, 2)
                           .Height.ToString();

            TestModuleLabel = engine.EngineValue.ToString();
        }


        
    }
}
