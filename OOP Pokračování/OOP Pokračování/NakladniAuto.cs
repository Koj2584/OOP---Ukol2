using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pokračování
{
    class NakladniAuto
    {
        private string spz;
        private short nosnost;
        private short hmotnostNakladu = 0;
        public short HmotnostNakladu
        {
            get
            {
                return hmotnostNakladu;
            }

        }

        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }

        public void NalozNaklad(short vaha)
        {
            if (vaha > nosnost)
            {
                hmotnostNakladu = nosnost;
                MessageBox.Show("Nenaložilo se " + (vaha - nosnost) + " tun.");
            }
            else
                hmotnostNakladu = vaha;
        }

        public void VylozNaklad(short vaha)
        {
            if (vaha > hmotnostNakladu)
            {
                MessageBox.Show("Chybějící náklad  " + (vaha - hmotnostNakladu) + " tun.");
                hmotnostNakladu = 0;
            }
            else
                hmotnostNakladu -= vaha;
        }

        public override string ToString()
        {
            return "Nákladní auto " + spz+" má nosnost " + nosnost + "t a má naloženo " + HmotnostNakladu + "t";
        }
    }
}
