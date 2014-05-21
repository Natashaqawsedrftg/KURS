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
    public partial class KLIENTSERVER : Form
    {
        public KLIENTSERVER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ConsoleClient.Program.Main1(textBox1.Text);
        }

        
    }
}
