using Core.Services;
using System.Linq;
using System.Windows.Forms;
using UI.Models;
using UI.ViewModels;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly RandomService _randomService;
        private NewEntryViewModel _newEntryViewModel;
        private EntriesViewModel _entriesViewModel;

        public Form1(RandomService randomService)
        {
            InitializeComponent();

            _newEntryViewModel = new NewEntryViewModel("");
            _entriesViewModel = new EntriesViewModel();

            NewEntryBindingSource.DataSource = _newEntryViewModel;
            EntriesBindingSource.DataSource = _entriesViewModel;
            _randomService = randomService;
        }

        private void AnlegenButton_Click(object sender, System.EventArgs e)
        {
            var entry = new Entry(_newEntryViewModel.Value);
            _entriesViewModel.Entries.Add(entry);
        }

        private void AuswahlButton_Click(object sender, System.EventArgs e)
        {
            if (_entriesViewModel.Entries.Count() == 0) return;

            var randomEntry = _randomService.GetRandomItem(_entriesViewModel.Entries);

            MessageBox.Show(randomEntry.Value);
        }

        private void LöschenButton_Click(object sender, System.EventArgs e)
        {
            if (!(entriesBindingSource1.Current is Entry entry)) return;

            entriesBindingSource1.RemoveCurrent();
        }
    }
}