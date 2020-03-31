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
        EntryRepository entryRepository = new EntryRepository();

        public Form1()
        {
            InitializeComponent();
            LoadEntries();
        }

        private void LoadEntries()
        {
            entryRepository.List()
                .ToList()
                .ForEach(e => SpassListe.Items.Add(e.Value));
        }

        private void AnlegenButton_Click(object sender, EventArgs e)
        {
            if (EintragBox.Text != "")
            {
                SpassListe.Items.Add(EintragBox.Text);
                entryRepository.Add(new Entry(EintragBox.Text));
                entryRepository.SaveChanges();
                EintragBox.Text = "";
            }
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            if (SpassListe.SelectedIndex != -1)
            {
                var entryInList = entryRepository.List().FirstOrDefault(z => z.Value == SpassListe.SelectedItem.ToString());
                entryRepository.Delete(entryInList);
                entryRepository.SaveChanges();
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
