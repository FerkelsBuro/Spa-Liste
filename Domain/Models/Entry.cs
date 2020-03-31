namespace Domain.Models
{
    public class Entry
    {
        private static int IdCounter = 0;

        public Entry(string value)
        {
            Value = value;
        }

        public int Id { get; set; }
        public string Value { get; set; }
    }
}