using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammerSuite.Components
{
    public class Entity
    {
        public String Value { get; set; }

        public String Translation { get; set; }

        public Entity(string value, string translation)
        {
            Value = value;
            Translation = translation;
        }
    }
}
