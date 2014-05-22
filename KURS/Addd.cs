using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursOOP
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
        
           
            // TODO: This line of code loads data into the 'myDBDataSet7.Tovar' table. You can move, or remove it, as needed.
            this.tovarTableAdapter.Fill(this.allDataSet.Tovar);
            
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                tovarBindingSource.EndEdit();
            else
                tovarBindingSource.CancelEdit();
        }

    }
}
