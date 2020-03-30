using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UI.Models;

namespace UI.ViewModels
{
    public class EntriesViewModel
    {
        public EntriesViewModel()
        {
        }

        public EntriesViewModel(IEnumerable<Entry> entries)
        {
            Entries = new BindingList<Entry>(entries.ToList());
        }

        public BindingList<Entry> Entries { get; set; } = new BindingList<Entry>();
    }
}