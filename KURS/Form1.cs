using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsoleClient;
namespace KURS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Klient_Click(object sender, EventArgs e)
        {
            Klient kl = new Klient();
            kl.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caters c = new Caters();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KLIENTSERVER k = new KLIENTSERVER();
            k.Show();
            //FormClient f = new FormClient();
            //f.Show();
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            Schet sch = new Schet();
            sch.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tovvar t = new Tovvar();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kursOOPpart2.Otchet o = new kursOOPpart2.Otchet();
            o.Show();
        }
    }
}
