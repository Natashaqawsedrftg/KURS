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
    public partial class AddCaterer : Form
    {
        public AddCaterer()
        {
            InitializeComponent();
        }

        private void AddCaterer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet4.Caterer' table. You can move, or remove it, as needed.
            this.catererTableAdapter.Fill(this.myDBDataSet4.Caterer);

        }

        private void AddCaterer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //если пользователь нажал на первую кнопку:
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                //сохранить изменения:
                catererBindingSource.EndEdit();
            else
                //не сохранять изменения:
               catererBindingSource.CancelEdit();

        }
    }
}
