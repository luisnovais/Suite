using System;

namespace Core.Suite
{
    public class Field
    {
        public String Name { get; set; }

        public String Type { get; set; }

        public FieldValue FieldValue { get; set; }

        public Field(string name, string type, FieldValue fieldValue)
        {
            Name = name;
            Type = type;
            FieldValue = fieldValue;
        }
    }
}
