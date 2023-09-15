using Pokus_1.Databases;
using Pokus_1.fileTransaction;
using Pokus_1.Generatory;
using Pokus_1.osoby;
using System.ComponentModel;
using System.Text;


namespace Pokus_1
{
    public partial class SpravaOsobForm : Form
    {
        OsobaManager osoby = new OsobaManager();
        private UpravitOsobuForm upravitOsobuForm;
        DatabaseOperations dbOperations = new DatabaseOperations();

        public SpravaOsobForm()
        {
            InitializeComponent();
            int highestID = dbOperations.GetHighestID();
            Osoba.SetLastUsedID(highestID);




            pohlaviCombo.DataSource = Enum.GetValues(typeof(Osoba.Pohlavi));
            LoadDataFromDatabase();
            dataGridView1.DataSource = osoby.osobaList;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> chybnaPole = new List<string>();

            if (string.IsNullOrEmpty(jmenoTxt.Text))
            {
                chybnaPole.Add("Jmeno");
            }
            if (string.IsNullOrEmpty(prijmeniTxt.Text))
            {
                chybnaPole.Add("Prijmeni");
            }
            if (string.IsNullOrEmpty(vekTxt.Text) || !int.TryParse(vekTxt.Text, out _))
            {
                chybnaPole.Add("Vek");
            }
            if (string.IsNullOrEmpty(mistoTxt.Text))
            {
                chybnaPole.Add("Misto");
            }

            if (chybnaPole.Count > 0)
            {
                string chybovaZprava = "Následující pole nejsou správně vyplněna nebo obsahují neplatnou hodnotu:\n" + string.Join(", ", chybnaPole);
                MessageBox.Show(chybovaZprava, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(int.Parse(vekTxt.Text)>15)
                {
                    // Získat vybranou hodnotu pohlaví z ComboBox
                    Osoba.Pohlavi vybranePohlavi = (Osoba.Pohlavi)pohlaviCombo.SelectedItem;

                    // Vytvořit instanci třídy Osoba s vybraným pohlavím
                    Osoba o = new Osoba(jmenoTxt.Text, prijmeniTxt.Text, int.Parse(vekTxt.Text), mistoTxt.Text, vybranePohlavi);

                    // Přidat osobu do seznamu osobaList nebo provést další akce podle vašich požadavků.
                    pridejData(o);
                }
                else
                {
                    MessageBox.Show("Takto mladá osoba nemůže dle zákona pracovat","Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void LoadDataFromDatabase()
        {
            DatabaseOperations dbOperations = new DatabaseOperations();

            // Zavolejte metodu pro načtení dat z databáze
            List<Osoba> loadedOsoby = dbOperations.LoadDataFromDatabase();

            // Vyprázdněte seznam osobaList
            osoby.osobaList.Clear();

            // Přidejte načtené osoby do seznamu osobaList
            foreach (Osoba loadedOsoba in loadedOsoby)
            {
                osoby.osobaList.Add(loadedOsoba);
            }

            // Aktualizujte DataSource dataGridView1 na načtená data
            dataGridView1.DataSource = null; // Nejdříve zrušte existující zdroj dat
            dataGridView1.DataSource = osoby.osobaList;
        }

        private void testDataBtn_Click(object sender, EventArgs e)
        {
            Generator gen = new Generator();
            Osoba o = gen.GenerateRandomOsoba();
            pridejData(o);
        }

        private void pridejData(Osoba o)
        {
            
            osoby.osobaList.Add(o);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Získání vybraného řádku
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Získání indexu vybraného řádku
                int rowIndex = selectedRow.Index;



                // Vytvoření okna pro úpravu dat a předání vybrané osoby
                upravitOsobuForm = new UpravitOsobuForm(osoby.osobaList[rowIndex], selectedRow);

                upravitOsobuForm.PropertyChanged += (s, args) =>
                {


                    // Aktualizace dat v seznamu osob
                    osoby.osobaList[rowIndex] = new Osoba(
                        osoby.osobaList[rowIndex].Id,
                        upravitOsobuForm.Jmeno,
                        upravitOsobuForm.Prijmeni,
                        upravitOsobuForm.Vek,
                        upravitOsobuForm.Misto,
                        upravitOsobuForm.Pohlavi
                    );
                };


                DialogResult result = upravitOsobuForm.ShowDialog();
            }
        }

        
        private void exportCsvBtn_Click(object sender, EventArgs e)
        {
            ExportCSV ex = new ExportCSV(osoby);

        }

        private void uploadCsvBtn_Click(object sender, EventArgs e)
        {
            UploadCSV uploadCSV = new UploadCSV();
            OsobaManager importOsoby = uploadCSV.ImportOsoby();

            // Aktualizujte osobaList v hlavním formuláři pomocí importovaných dat
            osoby = importOsoby;

            // Aktualizujte DataSource dataGridView1 na importovaná data
            dataGridView1.DataSource = osoby.osobaList;
        }

        private void dtbUlozBtn_Click(object sender, EventArgs e)
        {
            // Vytvořte seznam pro osoby k uložení a seznam pro aktualizace
            List<Osoba> osobyKUlozeni = new List<Osoba>();
            List<Osoba> osobyKAktualizaci = new List<Osoba>();

            foreach (Osoba osoba in osoby.osobaList)
            {
                int id = osoba.Id;

                if (!dbOperations.CheckIfIdExists(id))
                {
                    // Osoba neexistuje v databázi, přidáme ji k uložení
                    osobyKUlozeni.Add(osoba);
                }
                else
                {
                    // Osoba existuje v databázi, přidáme ji k aktualizaci
                    osobyKAktualizaci.Add(osoba);
                }
            }

            // Uložení nových osob
            foreach (Osoba osoba in osobyKUlozeni)
            {
                dbOperations.InsertData(osoba);
            }

            // Aktualizace existujících osob
            foreach (Osoba osoba in osobyKAktualizaci)
            {
                dbOperations.UpdateData(osoba);
            }

            MessageBox.Show("Záznamy úspěšně vloženy/upraveny v databázi", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void smazOsobuBtn_Click(object sender, EventArgs e)
        {
            // Zkontrolujte, zda je vybraný alespoň jeden řádek v DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Získání vybraného řádku
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Získání indexu vybraného řádku
                int rowIndex = selectedRow.Index;

                // Získání instance osoby z osobaList
                Osoba vybranaOsoba = osoby.osobaList[rowIndex];

                // Zobrazit dialogové okno pro potvrzení smazání
                DialogResult result = MessageBox.Show($"Opravdu chcete smazat osobu: {vybranaOsoba.Jmeno} {vybranaOsoba.Prijmeni}?", "Potvrdit smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Pokud uživatel potvrdí smazání, provedete následující kroky:

                    // Odebrat osobu ze seznamu osobaList
                    osoby.osobaList.RemoveAt(rowIndex);



                    // Dále můžete provést kód pro odstranění osoby z databáze
                    int id = vybranaOsoba.Id;
                    dbOperations.DeleteData(id); // Předpokládá se, že máte metodu pro odstranění dat z databáze
                }
            }

        }

    }

}
