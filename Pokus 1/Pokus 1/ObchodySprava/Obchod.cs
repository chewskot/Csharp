using Pokus_1.osoby;
using Pokus_1.Udaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokus_1.ObchodySprava
{
    public class Obchod
    {
        private int id;
        public Obchod() { }

        OsobaManager osoby = new OsobaManager();
        // Vlastnost pro název obchodu
        public string Nazev { get; set; }

        // Vlastnost pro adresu obchodu
        public Misto Adresa { get; set; }

        // Vlastnost pro manažera obchodu (jako instance třídy Osoba)
        public Osoba Manazer { get; set; }

        // Vlastnost pro telefonní číslo obchodu
        public string Telefon { get; set; }



        // Konstruktor pro inicializaci vlastností obchodu
        public Obchod(string nazev, Misto adresa, string telefon)
        {
            Nazev = nazev;
            Adresa = adresa;
            //Manazer = manazer; dodelat az budou hotovi zamestnanci
            Telefon = telefon;

        }

        // Metoda pro přidání pracovníka do seznamu pracovníků
        public void PridatPracovnika(Osoba pracovnik)
        {
            osoby.osobaList.Add(pracovnik);
        }

        // Metoda pro odebrání pracovníka ze seznamu pracovníků
        public void OdebratPracovnika(Osoba pracovnik)
        {
            osoby.osobaList.Remove(pracovnik);
        }

       
    }
}
