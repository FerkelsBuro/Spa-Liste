namespace UI.Models
{
    public class Entry
    {
        public Entry(string value)
        {
            Value = value;
        }

        public int Id { get; set; }
        public string Value { get; set; }
    }
}