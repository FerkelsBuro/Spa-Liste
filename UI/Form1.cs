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
        public Form1()
        {
            InitializeComponent();

            
        }

        private void AnlegenButton_Click(object sender, EventArgs e)
        {
            if (EintragBox.Text != "")
            {
                SpassListe.Items.Add(EintragBox.Text);
                EintragBox.Text = "";
            }
        }

        private void LöschenButton_Click(object sender, EventArgs e)
        {
            SpassListe.Items.Clear();
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
