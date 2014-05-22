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
    public partial class HHH : Form
    {
        public HHH()
        {
            InitializeComponent();
        }

        private void HHH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.Haracteristiki' table. You can move, or remove it, as needed.
            this.haracteristikiTableAdapter1.Fill(this.allDataSet.Haracteristiki);
          

        }

        private void HHH_FormClosing(object sender, FormClosingEventArgs e)
        {
            //если пользователь нажал на первую кнопку:
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                //сохранить изменения:
               haracteristikiBindingSource.EndEdit();
            else
                //не сохранять изменения:
                haracteristikiBindingSource.CancelEdit();

        }
    }
}
