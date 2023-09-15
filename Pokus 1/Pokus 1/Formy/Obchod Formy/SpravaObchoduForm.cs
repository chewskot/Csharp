using Pokus_1.Formy.Obchod_Formy;
using Pokus_1.ObchodySprava;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokus_1.Formy
{
    public partial class SpravaObchoduForm : Form
    {
        ObchodManager obchody = new ObchodManager();
        public SpravaObchoduForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = obchody.ObchodyList;
        }

        private void button1_Click(object sender, EventArgs e) // pridani obchodu idk proc to nejde zmenit
        {

            PridaniObchoduForm form = new PridaniObchoduForm();
            form.ShowDialog();  // Show the form as a dialog to wait for user input

            Obchod novyObchod = form.NovyObchod;  // Retrieve the new Obchod after the form is closed
            if (novyObchod != null)
            {
                obchody.ObchodyList.Add(novyObchod);
                // Update DataGridView
                dataGridView1.DataSource = null;  // Clear the existing data source
                dataGridView1.DataSource = obchody.ObchodyList;  // Set the updated data source
            }



        }

        private void odebraniObchoduBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
