using Pokus_1.osoby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokus_1.Obchod
{
    internal class Obchod
    {
            OsobaManager osoby = new OsobaManager();
            // Vlastnost pro název obchodu
            public string Nazev { get; set; }

            // Vlastnost pro adresu obchodu
            public string Adresa { get; set; }

            // Vlastnost pro manažera obchodu (jako instance třídy Osoba)
            public Osoba Manazer { get; set; }

            // Vlastnost pro telefonní číslo obchodu
            public string Telefon { get; set; }

            // Seznam pracovníků v obchodě
            public List<Osoba> Pracovnici { get; set; }

            // Konstruktor pro inicializaci vlastností obchodu
            public Obchod(string nazev, string adresa, Osoba manazer, string telefon)
            {
                Nazev = nazev;
                Adresa = adresa;
                Manazer = manazer;
                Telefon = telefon;
                Pracovnici = new List<Osoba>();
            }

            // Metoda pro přidání pracovníka do seznamu pracovníků
            public void PridatPracovnika(Osoba pracovnik)
            {
                Pracovnici.Add(pracovnik);
            }

            // Metoda pro odebrání pracovníka ze seznamu pracovníků
            public void OdebratPracovnika(Osoba pracovnik)
            {
                Pracovnici.Remove(pracovnik);
            }
        
    }
}
