using System;
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
            // TODO: This line of code loads data into the 'allDataSet.Haracteristiki' table. You can move, or remove it, as needed.
            this.haracteristikiTableAdapter.Fill(this.allDataSet.Haracteristiki);
           
            
           
            
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
               haracteristikiTableAdapter.Update(this.allDataSet.Haracteristiki);

        }

        private void delete_Click(object sender, EventArgs e)
        {
          //пометка на удаление:
            haracteristikiBindingSource.RemoveCurrent();

           //сохранение изменений:
            haracteristikiBindingSource.EndEdit();

           //выгрузка в DataGridView обновленных данных:
           haracteristikiTableAdapter.Update(this.allDataSet.Haracteristiki); 

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
                haracteristikiTableAdapter.Update(this.allDataSet.Haracteristiki);

        }

        private void button3_Click(object sender, EventArgs e)
        {      Class1 u = new Class1(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf");
        string u8 = "insert into Haracteristiki (nazvanietovara) SELECT all (name) from Tovar";
        MessageBox.Show(u.ExecSQL(u8));
        }

      

       

        
    }
}
