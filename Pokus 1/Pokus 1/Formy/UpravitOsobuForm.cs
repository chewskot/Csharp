using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokus_1.osoby;

namespace Pokus_1
{
    public partial class UpravitOsobuForm : Form
    {
        public event EventHandler PropertyChanged;
        public string Jmeno
        {
            get { return uprJmenoTxt.Text; }
        }

        public string Prijmeni
        {
            get { return uprPrijmeniTxt.Text; }
        }
       
        public int Vek
        {
            get { return int.Parse(uprVekTxt.Text); }
        }

        public string Misto
        {
            get { return uprMistoTxt.Text; }
        }

        public Osoba.Pohlavi Pohlavi
        {
            get { return (Osoba.Pohlavi)uprPohlaviCombo.SelectedItem; }
        }

        public UpravitOsobuForm()
        {
            InitializeComponent();
            uprPohlaviCombo.DataSource = Enum.GetValues(typeof(Osoba.Pohlavi));
        }
        private DataGridViewRow vybranyRadek;

      
        public UpravitOsobuForm(Osoba osoba, DataGridViewRow radek)
        {
            InitializeComponent();
            uprPohlaviCombo.DataSource = Enum.GetValues(typeof(Osoba.Pohlavi));
            vybranyRadek = radek;


            // Nastavte hodnoty z předané osoby do polí ve formuláři pro úpravu
            uprJmenoTxt.Text = osoba.jmeno;
            uprPrijmeniTxt.Text = osoba.prijmeni;
            uprVekTxt.Text = osoba.vek.ToString();
            uprMistoTxt.Text = osoba.misto;
            uprPohlaviCombo.SelectedItem = osoba.gender;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, EventArgs.Empty);
            }

            // Zavřete okno
            this.Close();

        }

        private void zrusBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
