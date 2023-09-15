using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokus_1.ObchodySprava;
using Pokus_1.Udaje;

namespace Pokus_1.Formy.Obchod_Formy
{
    public partial class PridaniObchoduForm : Form
    {
        Obchod novyObchod;
        Misto m;
        public PridaniObchoduForm()
        {
            InitializeComponent();
        }

        
        public PridaniObchoduForm(Obchod o)
        {
            InitializeComponent();
            
    
        }
        public Obchod NovyObchod
        {
            get { return novyObchod; }
        }


        private void button1_Click(object sender, EventArgs e) // pridani obchodu
        {



            
            
            m = new Misto(cisloTxt.Text, uliceTxt.Text, mestoTxt.Text, pscTxt.Text, statTxt.Text);
                // Získání nového obchodu z formuláře PridaniObchoduForm
                 novyObchod = new Obchod(nazevObchoduTxt.Text, m, telefonTxt.Text);

                // Přidání nového obchodu do ObchodManager a BindingList
                
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e) //odebrani
        {
            this.Close();
        }
    }
}
