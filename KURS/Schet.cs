using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace KURS
{
    public partial class Schet : Form
    {
        public Schet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream f = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader rd = new StreamReader(f);
            myDBDataSet5 dataset = new myDBDataSet5();
            myDBDataSet5TableAdapters.KlientTableAdapter klientTA = new myDBDataSet5TableAdapters.KlientTableAdapter();
            klientTA.Fill(dataset.Klient);
            string inpstr;
            string output = "";
            string[] str; int i = 0;
            while (((inpstr = rd.ReadLine()) != null) && (i < 20))
            {
                str = inpstr.Split('\n');
                string[] s = str[0].Split('=');
                if (i == 16) output += "Номер счета: " + s[1] + Environment.NewLine;
                if (i == 17) output += "Дата: " + s[1] + Environment.NewLine;
                if (i == 18) output += "Сумма: " + s[1] + Environment.NewLine;
                if (i == 19) { var c = from obj in dataset.Klient.AsEnumerable() where obj.schet == Convert.ToInt32(s[1]) select obj; foreach (var obj in c) { output += "Плательщик: " + obj.SIF + Environment.NewLine; } }
                i++;
            }
            MessageBox.Show(output);
        }

        private void Schet_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'myDBDataSet5.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.myDBDataSet5.Klient);

        }
    }
}
