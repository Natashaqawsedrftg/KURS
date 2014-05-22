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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet6.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.myDBDataSet6.Klient);
          

        }

        private void DeleteKLient_Click(object sender, EventArgs e)
        {
            //пометка на удаление:
            klientBindingSource.RemoveCurrent();

            //сохранение изменений:
            klientBindingSource.EndEdit();

            //выгрузка в DataGridView обновленных данных:
            klientTableAdapter.Update(this.myDBDataSet6.Klient); 

        }

        private void AddKlient_Click(object sender, EventArgs e)
        {  //создаем объект второй формы:
            Dobavit_ dobkl = new Dobavit_();

            //добавляем новую запись в таблицу:
            klientBindingSource.AddNew();

            //синхронизируем компоненты bindingSource обоих форм:
            dobkl.klientBindingSource1.DataSource = klientBindingSource;

            //чтобы они указывали в таблице на одну и ту же запись:
            dobkl.klientBindingSource1.Position = klientBindingSource.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (dobkl.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                klientTableAdapter.Update(this.myDBDataSet6.Klient);

        }

        private void EditKlient_Click(object sender, EventArgs e)
        {
            //создаем объект второй формы:
            Dobavit_ dobkl = new Dobavit_();

            //синхронизируем компоненты bindingSource обоих форм:
            dobkl.klientBindingSource1.DataSource = klientBindingSource;

            //чтобы они указывали в таблице на одну и ту же запись:
            dobkl.klientBindingSource1.Position = klientBindingSource.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (dobkl.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                klientTableAdapter.Update(this.myDBDataSet6.Klient);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Haracter h = new Haracter();
            h.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ХарактеристикиБаза f = new ХарактеристикиБаза();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //Skidka s = new Skidka();

           //s.Show();
            Mail m = new Mail();
            //m.Message("smtp.mail.ru", 25);

        }
    }
}
