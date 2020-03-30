using System.Windows.Forms;
using UI.Models;
using UI.ViewModels;

namespace UI
{
    public partial class Form1 : Form
    {
        private NewEntryViewModel _newEntryViewModel;
        private EntriesViewModel _entriesViewModel;

        public Form1()
        {
            InitializeComponent();

            _newEntryViewModel = new NewEntryViewModel("");
            _entriesViewModel = new EntriesViewModel();

            NewEntryBindingSource.DataSource = _newEntryViewModel;
            EntriesBindingSource.DataSource = _entriesViewModel;
        }

        private void AnlegenButton_Click(object sender, System.EventArgs e)
        {
            var entry = new Entry(_newEntryViewModel.Value);
            _entriesViewModel.Entries.Add(entry);
        }
    }
}