using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokus_1.Udaje
{
    public class Misto
    {
        private string cisloDomu;
        private string nazevUlice;
        private string mesto;
        private string psc;
        private string stat;

        public string CisloDomu
        {
            get { return cisloDomu; }
            set { cisloDomu = value; }
        }

        public string NazevUlice
        {
            get { return nazevUlice; }
            set { nazevUlice = value; }
        }

        public string Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }

        public string PSC
        {
            get { return psc; }
            set { psc = value; }
        }

        public string Stat
        {
            get { return stat; }
            set { stat = value; }
        }

        public Misto(string cisloDomu, string nazevUlice, string mesto, string psc, string stat)
        {
            CisloDomu = cisloDomu;
            NazevUlice = nazevUlice;
            Mesto = mesto;
            PSC = psc;
            Stat = stat;
        }

        public override string ToString()
        {
            return $"{NazevUlice} {CisloDomu}, {Stat}, {Mesto}, {PSC}";
        }
    }
}
