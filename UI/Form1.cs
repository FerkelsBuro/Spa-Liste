using Domain.Models;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private IEntryRepository _entryRepository;

        public Form1(IEntryRepository entryRepository)
        {
            InitializeComponent();

            _entryRepository = entryRepository;
            LoadEntries();
        }

        private void LoadEntries()
        {
            _entryRepository.List()
                .ToList()
                .ForEach(e => SpassListe.Items.Add(e.Value));
        }

        private void AnlegenButton_Click(object sender, EventArgs e)
        {
            if (EintragBox.Text != "")
            {
                SpassListe.Items.Add(EintragBox.Text);
                _entryRepository.Add(new Entry(EintragBox.Text));
                _entryRepository.SaveChanges();
                EintragBox.Text = "";
            }
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            if (SpassListe.SelectedIndex != -1)
            {
                var entryInList = _entryRepository.List().FirstOrDefault(z => z.Value == SpassListe.SelectedItem.ToString());
                _entryRepository.Delete(entryInList);
                _entryRepository.SaveChanges();
                SpassListe.Items.RemoveAt(SpassListe.SelectedIndex);
                
            }
            else
            {
                MessageBox.Show("Kein Element ausgewählt!");
            }
        }

        private void AuswahlButton_Click(object sender, EventArgs e)
        {
            if (SpassListe.Items.Count > 0)
            {
                Random random = new Random();
                MessageBox.Show(SpassListe.Items[random.Next(SpassListe.Items.Count)].ToString());
            }
            else
            {
                MessageBox.Show("Liste ist leer!");
            }
        }

        private void EintragBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AnlegenButton.PerformClick();
            }
        }
    }
}
