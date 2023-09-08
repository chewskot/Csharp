using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokus_1.osoby
{

    public class Osoba
    {
        private static int lastUsedID = 0;
        public int id { get; private set; }
        
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public int vek { get; set; }
        public string misto { get; set; }
        public static void SetLastUsedID(int id)
        {
            lastUsedID = id;
        }
        public enum Pohlavi
        {
            Muz,
            Zena,
            Ostatni
        }
        public int getId()
        {
            return id;
        }
        public Pohlavi gender { get; set; }


        public Osoba() { }

        public Osoba(
             string jmeno, string prijmeni, int vek, string misto, Pohlavi gender)
        {
            this.id = ++lastUsedID;
            this.vek = vek;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.misto = misto;
            this.gender = gender;
        }
       
        public Osoba(
            int id, string jmeno, string prijmeni, int vek, string misto, Pohlavi gender)
        {
            this.id = id;
            this.vek = vek;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.misto = misto;
            this.gender = gender;
        }
        public override string ToString()
        {
            return $"{vek};{jmeno};{prijmeni};{misto};{gender}";
        }
    }
}



