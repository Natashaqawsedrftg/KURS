using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kursOOP;

namespace KURS
{
    public partial class Tovvar : Form
    {
        public Tovvar()
        {
            InitializeComponent();
        }

        private void Tovvar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet7.Tovar' table. You can move, or remove it, as needed.
            this.tovarTableAdapter.Fill(this.myDBDataSet7.Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kursOOP.Add a = new kursOOP.Add();
             //a.Show();
            a.tovarBindingSource.AddNew();
            a.tovarBindingSource.DataSource = tovarBindingSource;
            a.tovarBindingSource.Position = tovarBindingSource.Position;
            if (a.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                tovarTableAdapter.Update(this.myDBDataSet7.Tovar);
        
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kursOOP.Add a = new kursOOP.Add();
            a.tovarBindingSource.DataSource = tovarBindingSource;
            a.tovarBindingSource.Position = tovarBindingSource.Position;
            if (a.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tovarTableAdapter.Update(this.myDBDataSet7.Tovar);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //////пометка на удаление:
            tovarBindingSource.RemoveCurrent();
            //////сохранение изменений:
            tovarBindingSource.EndEdit();
            //выгрузка в DataGridView обновленных данных:
            tovarTableAdapter.Update(this.myDBDataSet7.Tovar);
        }
    }
}
