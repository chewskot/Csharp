using Pokus_1.osoby;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Pokus_1
{
    public class UploadCSV
    {


        public OsobaManager ImportOsoby()
        {
            OsobaManager importOsoby = new OsobaManager();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"; // Určete, jaké typy souborů lze vybrat
                openFileDialog.Title = "Vyberte CSV soubor pro import"; // Název dialogového okna
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;

                    try
                    {
                        // Přečtěte obsah vybraného CSV souboru
                        string[] csvLines = File.ReadAllLines(selectedPath);

                        // Projděte každý řádek CSV souboru a přidejte data do importovaného osobaList
                        foreach (string csvLine in csvLines)
                        {
                            string[] values = csvLine.Split(',');
                            if (values.Length == 5) // Ověřte, že řádek obsahuje očekávaný počet hodnot
                            {
                                // Vytvořte novou instanci Osoba a přidejte ji do importovaného osobaList
                                Osoba novaOsoba = new Osoba(
                                    
                                    values[0],
                                    values[1],
                                    int.Parse(values[2]),
                                    values[3],
                                    (Osoba.Pohlavi)Enum.Parse(typeof(Osoba.Pohlavi), values[4])
                                );
                                importOsoby.osobaList.Add(novaOsoba);
                            }
                        }

                        // Zobrazte zprávu o úspěšném načtení
                        MessageBox.Show($"Data byla načtena z CSV souboru: {selectedPath}");
                    }
                    catch (Exception ex)
                    {
                        // Zobrazte chybovou zprávu v případě chyby
                        MessageBox.Show($"Chyba při načítání CSV souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return importOsoby; // Vraťte načtená data po úspěšném importu
        }


    }
}
