using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KURS
{
    public partial class Skidka : Form
    {
        public Skidka()
        {
            InitializeComponent();
        }
        public double met()
        {
            double result = 1;
            if (checkBox1.Checked == true)
            { result = 7; }
            if (System.Convert.ToDouble(textBox1.Text) > 1000)
            { result = result * (System.Convert.ToDouble(textBox1.Text) / 1000) + System.Convert.ToDouble(textBox2.Text); }
            else { result = result + System.Convert.ToDouble(textBox2.Text); }
            return result;
        }
        private void Skidka_Load(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(met().ToString());
        }
    }
}
