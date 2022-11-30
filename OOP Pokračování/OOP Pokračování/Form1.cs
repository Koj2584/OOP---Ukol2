using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Pokračování
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto auto;

        private void button1_Click(object sender, EventArgs e)
        {
            auto = new NakladniAuto(textBox1.Text, (short)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.NalozNaklad((short)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.VylozNaklad((short)numericUpDown3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto.ToString());
        }
    }
}
