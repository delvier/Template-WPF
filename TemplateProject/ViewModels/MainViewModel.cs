namespace TemplateProject.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public string TestLabel { get; set; }

        public MainViewModel(Foo foo)
        {
            TestLabel = foo.Do(1, 2)
                           .Height.ToString();
        }
    }
}
