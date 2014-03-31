namespace Core.Suite
{
    public class FieldValue
    {
        public string Value { get; set; }

        public string Type { get; set; }

        public FieldValue(string value, string type)
        {
            Value = value;
            Type = type;
        }

        public FieldValue()
        {
        }
    }
}
