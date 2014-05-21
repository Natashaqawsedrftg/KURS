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
            // TODO: This line of code loads data into the 'myDBDataSet4.Caterer' table. You can move, or remove it, as needed.
            this.catererTableAdapter.Fill(this.myDBDataSet4.Caterer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCaterer f = new AddCaterer();

            //добавляем новую запись в таблицу:
            catererBindingSource.AddNew();

            //синхронизируем компоненты bindingSource обоих форм:
            f.catererBindingSource.DataSource = catererBindingSource;

            //чтобы они указывали в таблице на одну и ту же запись:
            f.catererBindingSource.Position = catererBindingSource.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                catererTableAdapter.Update(this.myDBDataSet4.Caterer);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //создаем объект второй формы:
            AddCaterer f = new AddCaterer();

            f.catererBindingSource.DataSource = catererBindingSource;

            //чтобы они указывали в таблице на одну и ту же запись:
            f.catererBindingSource.Position = catererBindingSource.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                catererTableAdapter.Update(this.myDBDataSet4.Caterer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //пометка на удаление:
            catererBindingSource.RemoveCurrent();

            //сохранение изменений:
            catererBindingSource.EndEdit();

            //выгрузка в DataGridView обновленных данных:
            catererTableAdapter.Update(this.myDBDataSet4.Caterer); 

        }
    }
}
