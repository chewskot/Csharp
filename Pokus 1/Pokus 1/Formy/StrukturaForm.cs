using Pokus_1.Formy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokus_1
{
    public partial class StrukturaForm : Form
    {
        public StrukturaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpravaOsobForm sp = new SpravaOsobForm();
            sp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpravaObchoduForm fr = new SpravaObchoduForm();
            fr.Show();
        }
    }
}
