using System;
using System.Windows.Forms;

namespace Pokus_1.osoby
{
    public class Osoba
    {
        private static int lastUsedID = 0;
        private int id;
        private string jmeno;
        private string prijmeni;
        private int vek;
        private string misto;
        private Pohlavi gender;
       

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public static void SetLastUsedID(int id)
        {
            lastUsedID = id;
        }

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }

        public int Vek
        {
            get { return vek; }
            set
            {
               
                    vek = value;
             
            }
        }

        public string Misto
        {
            get { return misto; }
            set { misto = value; }
        }
        

        public Pohlavi Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Osoba() { }

        public Osoba(string jmeno, string prijmeni, int vek, string misto, Pohlavi gender)
        {
         
                this.id = ++lastUsedID;
                this.Vek = vek;
                this.jmeno = jmeno;
                this.prijmeni = prijmeni;
                this.misto = misto;
                this.gender = gender;
           
        }

        public Osoba(int id, string jmeno, string prijmeni, int vek, string misto, Pohlavi gender)
        {
            
                this.id = id;
                this.Vek = vek;
                this.jmeno = jmeno;
                this.prijmeni = prijmeni;
                this.misto = misto;
                this.gender = gender;
         
        }

        public override string ToString()
        {
            return $"{vek};{jmeno};{prijmeni};{misto};{gender}";
        }

        public enum Pohlavi
        {
            Muz,
            Zena,
            Ostatni
        }

        public int GetId()
        {
            return id;
        }
    }
}
