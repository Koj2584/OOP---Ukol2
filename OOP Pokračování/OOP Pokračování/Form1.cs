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

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(textBox1.Text, textBox2.Text, dateTimePicker1.Value);
            s1.Znamka = (int)numericUpDown1.Value;
            MessageBox.Show(s1.ToString());
        }
    }
}
