namespace SQLiteSample2.Data.Entity
{
    public class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return $"Key: {Key}, Value: {Value}";
        }
    }
}
