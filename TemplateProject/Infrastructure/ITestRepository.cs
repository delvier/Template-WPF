using System.Collections.Generic;

namespace TemplateProject.Infrastructure
{
    public interface ITestRepository
    {
        IEnumerable<Test> GetAll();
    }

    public class TestRepository : ITestRepository
    {
        public IEnumerable<Test> GetAll()
        {
            return new List<Test>()
            {
                new Test() {Name = "Test some names", Description = "Another strange description"},
                new Test() {Name = "Database Test"},
                new Test() {Name = "Interface Original Test", Description = "Nothing more than silly description"}
            };
        }
    }
}