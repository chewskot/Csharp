using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokus_1.osoby;

namespace Pokus_1.fileTransaction
{
    internal class ExportCSV
    {
        public ExportCSV(OsobaManager osoby)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"; // Určete, že chcete exportovat do CSV souboru
                saveFileDialog.Title = "Vyberte umístění pro uložení CSV souboru"; // Název dialogového okna
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = saveFileDialog.FileName;

                    // Exportujte obsah osobaList do CSV souboru
                    StringBuilder csvContent = new StringBuilder();
                    foreach (Osoba osoba in osoby.osobaList)
                    {
                        // Přidejte řádek CSV souboru pro každou osobu
                        string csvLine = $"{osoba.jmeno},{osoba.prijmeni},{osoba.vek},{osoba.misto},{osoba.gender}";
                        csvContent.AppendLine(csvLine);
                    }

                    // Uložte obsah do vybraného souboru
                    File.WriteAllText(selectedPath, csvContent.ToString());

                    MessageBox.Show($"CSV soubor byl uložen na: {selectedPath}");
                }
            }


        }


    }
}
