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
        public short HmotnostNakladu {
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
                hmotnostNakladu = 0;
                MessageBox.Show("Chybějící náklad  " + (vaha - hmotnostNakladu) + " tun.");
            }
            else
                hmotnostNakladu -= vaha;
        }


    }
}
