using System;
using System.Collections.Generic;

namespace Core.Suite
{
    public class Entity
    {
        public String TableName { get; set; }

        public IEnumerable<String> FieldsList { get; set; }

        public String Value { get; set; }

        public String ValueType { get; set; }

        public String Translation { get; set; }

        public Entity(string value, string translation)
        {
            Value = value;
            Translation = translation;
        }
    }
}
