using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Data.SqlServerCe;

using Uprav;




namespace KURS
{

    public partial class Haracter : Form
    {

        public Haracter()
        {
            InitializeComponent();
        }
       


        private void button1_Click(object sender, EventArgs e)
        {

            Class1 u = new Class1(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf");
            string query1 = "drop TABLE Smotrim";
            MessageBox.Show(u.ExecSQL(query1));
            string query = "CREATE TABLE Smotrim (id INT Identity PRIMARY KEY,vampodhodit nvarchar(20),potipuvolos nvarchar(30), potipulica nvarchar(30));";
           u.ExecSQL(query);
            string uu= "insert into Smotrim (vampodhodit) SELECT (nazvanietovara) from Haracteristiki where (Kto) =('"+checkedListBox4.Text+"') and (Vozrast) =('"+checkedListBox3.Text+"') and (Tiptovara)=('"+checkedListBox5.Text+"')";
            string u1 = "insert into Smotrim (potipuvolos) SELECT (nazvanietovara) from Haracteristiki where (TipVolos) =('"+checkedListBox2.Text+"') and (Tiptovara)=('"+checkedListBox5.Text+"')";
            string u2 = "insert into Smotrim (potipulica) SELECT (nazvanietovara) from Haracteristiki where (Tiplica) =('" + checkedListBox1.Text + "') and (Tiptovara)=('" +checkedListBox5.Text +"')";
          
          u.ExecSQL(uu);
            u.ExecSQL(u1);
         u.ExecSQL(u2);
            Vremen v = new Vremen();
            v.Show();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

