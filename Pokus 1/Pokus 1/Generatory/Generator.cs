using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokus_1.osoby;

namespace Pokus_1.Generatory
{
    public class Generator
    {
        private Random rand = new Random();
        List<string> jmena = new List<string>
    {
        "Jan", "Petr", "Jana", "Marie", "Josef", "Eva", "Miroslav", "Hana", "Michal", "Anna"
    };

        List<string> prijmeni = new List<string>
    {
        "Novák", "Svoboda", "Nováková", "Dvořák", "Černá", "Marek", "Procházka", "Kovář", "Kučera", "Pospíšil"
    };

        List<string> mesta = new List<string>
    {
        "Praha", "Brno", "Ostava", "Olomouc", "Pardubice", "Pičín", "Neratovice", "Tábor", "Plzeň", "Sokolov"
    };

        public Osoba GenerateRandomOsoba()
        {
            string nahodneJmeno = jmena[rand.Next(jmena.Count)];
            string nahodnePrijmeni = prijmeni[rand.Next(prijmeni.Count)];
            int nahodnyVek = rand.Next(15, 100);
            string nahodneMisto = mesta[rand.Next(prijmeni.Count)];
            Osoba.Pohlavi nahodnePohlavi = (Osoba.Pohlavi)rand.Next(0, Enum.GetValues(typeof(Osoba.Pohlavi)).Length);

           

            return new Osoba(nahodneJmeno, nahodnePrijmeni, nahodnyVek, nahodneMisto, nahodnePohlavi);
        }
        public Generator() { }

    }
}
