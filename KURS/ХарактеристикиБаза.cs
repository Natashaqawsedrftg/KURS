﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Uprav;

namespace KURS
{
    public partial class ХарактеристикиБаза : Form
    {
        public ХарактеристикиБаза()
        {
            InitializeComponent();
        }

        private void ХарактеристикиБаза_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet1.Haracteristiki". При необходимости она может быть перемещена или удалена.
            this.haracteristikiTableAdapter.Fill(this.myDBDataSet1.Haracteristiki);
            
//            Class1 u = new Class1(@"C:\Users\Андрей свали с компа\Desktop\myDB.sdf");
//            string u2 = "insert into Haracteristiki (nazvanietovara) SELECT (name) from Tovar";
//MessageBox.Show(u.ExecSQL(u2));
        }

        private void AddHar_Click(object sender, EventArgs e)
        {
         // //создаем объект второй формы:
           HHH f = new HHH();

        //    //добавляем новую запись в таблицу:
           haracteristikiBindingSource.AddNew();

        //    //синхронизируем компоненты bindingSource обоих форм:
           f.haracteristikiBindingSource.DataSource = haracteristikiBindingSource;

        //    //чтобы они указывали в таблице на одну и ту же запись:
            f.haracteristikiBindingSource.Position = haracteristikiBindingSource.Position;

        //    //если пользователь в форме добавления нажал на первую кнопку:
           if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)

        //        //осуществляем выгрузку в DataGridView обновленных данных:
               haracteristikiTableAdapter.Update(this.myDBDataSet1.Haracteristiki);

        }

        private void delete_Click(object sender, EventArgs e)
        {
          //пометка на удаление:
            haracteristikiBindingSource.RemoveCurrent();

           //сохранение изменений:
            haracteristikiBindingSource.EndEdit();

           //выгрузка в DataGridView обновленных данных:
           haracteristikiTableAdapter.Update(this.myDBDataSet1.Haracteristiki); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            HHH f = new HHH();
            //синхронизируем компоненты bindingSource обоих форм:
            f.haracteristikiBindingSource.DataSource = haracteristikiBindingSource;

            //чтобы они указывали в таблице на одну и ту же запись:
            f.haracteristikiBindingSource.Position = haracteristikiBindingSource.Position;

            //если пользователь в форме добавления нажал на первую кнопку:
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                //осуществляем выгрузку в DataGridView обновленных данных:
                haracteristikiTableAdapter.Update(this.myDBDataSet1.Haracteristiki);

        }

       

        
    }
}
