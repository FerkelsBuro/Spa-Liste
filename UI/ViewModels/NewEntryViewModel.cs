namespace UI.ViewModels
{
    public class NewEntryViewModel
    {
        public NewEntryViewModel(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}