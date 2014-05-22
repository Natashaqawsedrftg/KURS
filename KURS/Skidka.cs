using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursOOPpart2
{
    public partial class Skidka : Form
    {
        double sum;
        public Skidka(double sum)
        {
            this.sum = sum;
            InitializeComponent();
        }
        public double met()
        {
            double result = 1;
            if (checkBox1.Checked == true)
            { result = 7; }
            if (System.Convert.ToDouble(label4.Text) > 1000)
            { result = result * (System.Convert.ToDouble(label4.Text) / 1000) + System.Convert.ToDouble(textBox2.Text); }
            else { result = result + System.Convert.ToDouble(textBox2.Text); }
            return result;
        }
        private void Skidka_Load(object sender, EventArgs e)
        {
            label4.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(met().ToString());
            this.Close();
        }

    }
}
