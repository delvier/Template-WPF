using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineModuleProject
{
    public class Engine : IEngine
    {
        public int EngineValue { get; set; }

        public Engine()
        {
            EngineValue = 666;
        }

    }
}
