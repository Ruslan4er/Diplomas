using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologicalEquipApp
{
    class Theory
    {
        public string Name { get; }
        public string Path { get; }

        public Theory(string path, string name)
        {
            Path = path;
            Name = name;
        }
    }
}
