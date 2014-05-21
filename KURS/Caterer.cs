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
    public partial class Caterer : Form
    {
        public Caterer()
        {
            InitializeComponent();
        }

        private void Caterer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet4.Сaterer' table. You can move, or remove it, as needed.
            this.сatererTableAdapter.Fill(this.myDBDataSet4.Caterer);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //catererBindingSource.RemoveCurrent();

            ////сохранение изменений:
            //catererBindingSource.EndEdit();

            ////выгрузка в DataGridView обновленных данных:
            //catererTableAdapter.Update(this.myDBDataSet4.Caterer); 


        }
    }
}
