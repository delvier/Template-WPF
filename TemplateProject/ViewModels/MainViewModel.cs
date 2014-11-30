using System.Collections.Generic;
using EngineModuleProject;
using Microsoft.Practices.Prism.Mvvm;
using TemplateProject.Infrastructure;

namespace TemplateProject.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly ITestRepository _testRepository;

        public MainViewModel(ITestRepository testRepository, IEngine engine)
        {
            _testRepository = testRepository;
        }

        public IEnumerable<Test> Tests
        {
            get
            {
                return _testRepository.GetAll();
                
            }
        }
    }
}
