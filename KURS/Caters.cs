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
    public partial class Caters : Form
    {
        public Caters()
        {
            InitializeComponent();
        }

        private void Caters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.Caterer' table. You can move, or remove it, as needed.
            this.catererTableAdapter1.Fill(this.allDataSet.Caterer);
            // TODO: This line of code loads data into the 'myDBDataSet4.Caterer' table. You can move, or remove it, as needed.
            this.catererTableAdapter1.Fill(this.allDataSet.Caterer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCaterer f = new AddCaterer();

            //добавляем новую запись в таблицу:
            catererBindingSource1.AddNew();

            //синхронизируем компоненты bindingSource обоих форм:
            
            f.catererBindingSource.DataSource = catererBindingSource1;

            //чтобы они указывали в таблице на одну и ту же запись:
            f.catererBindingSource.Position = catererBindingSource1.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                catererTableAdapter1.Update(this.allDataSet.Caterer);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //создаем объект второй формы:
            AddCaterer f = new AddCaterer();

            f.catererBindingSource.DataSource = catererBindingSource1;

            //чтобы они указывали в таблице на одну и ту же запись:
            f.catererBindingSource.Position = catererBindingSource1.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                catererTableAdapter1.Update(this.allDataSet.Caterer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //пометка на удаление:
            catererBindingSource1.RemoveCurrent();

            //сохранение изменений:
            catererBindingSource1.EndEdit();

            //выгрузка в DataGridView обновленных данных:
            catererTableAdapter1.Update(this.allDataSet.Caterer); 

        }
    }
}
