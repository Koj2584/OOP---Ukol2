using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pokračování
{
    class Student
    {
        public string Jmeno { get; }
        public string Prijmeni { get; set; }
        private DateTime datumNarozeni;
        public DateTime DatumNarozeni
        {
            get
            {
                return datumNarozeni;
            }
            set
            {
                if (value > DateTime.Now)
                    MessageBox.Show("Zadal jste budoucí datum!!!");
                else
                    datumNarozeni = value;
            }
        }
        private int znamka;
        public int Znamka
        {
            get
            {
                if (znamka == 0)
                    MessageBox.Show("Neproběhla klasifikace!!");
                return znamka;
            }
            set
            {
                if (value > 5 || value < 1)
                    znamka = 0;
                else
                    znamka = value;
            }
        }

        public Student(string jmeno,string prijmrni, DateTime datumNarozrni)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmrni;
            this.DatumNarozeni = datumNarozrni;
        }

        public bool Sleva()
        {
            TimeSpan ts = DateTime.Now - DatumNarozeni;
            if (ts.Days / 365.25 < 26)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Student " + Jmeno + " " + Prijmeni + " narozen " + DatumNarozeni.ToString("d") + " se známkou " + Znamka + " a " + (Sleva() ? "se slevou." : "beze slevy.");
        }
    }
}
