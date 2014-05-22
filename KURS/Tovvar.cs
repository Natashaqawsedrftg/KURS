using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using kursOOP;
using TovarLib;
//using ClassLibrary1;

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

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream f = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader rd = new StreamReader(f);
            string[] str;
            string inpstr;
            List<Tovar> tov = new List<Tovar>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tov.Add(new Tovar(Convert.ToInt32(dataGridView1[0, i].Value), Convert.ToString(dataGridView1[1, i].Value), Convert.ToDateTime(dataGridView1[2, i].Value), Convert.ToInt32(dataGridView1[3, i].Value), 0));
            }
            while ((inpstr = rd.ReadLine()) != null)
            {
                str = inpstr.Split(' ');
                Tovar t = new Tovar(Convert.ToInt32(str[0]), str[1], Convert.ToDateTime(str[2]), Convert.ToInt32(str[3]), Convert.ToDecimal(str[4]));
                using (SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf"))
                {
                    conn.Open();
                    using (SqlCeCommand c = new SqlCeCommand(@"insert into tovar(name, srok, kolvo, price) values('" + t.name + "','"+t.srok.Date+"',"  + t.kolvo + "," + t.prise.ToString().Replace(',','.')+")"))
                    {
                        c.Connection = conn;
                        c.ExecuteNonQuery();
                    }
                }

            }
            rd.Close();
            this.tovarTableAdapter.Fill(this.myDBDataSet7.Tovar);
            tovarTableAdapter.Update(this.myDBDataSet7.Tovar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = ""; string ctr = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((DateTime)dataGridView1[2, i].Value < DateTime.Now.Date)
                    str += dataGridView1[1, i].Value.ToString() + Environment.NewLine;
                if (Convert.ToInt32(dataGridView1[3, i].Value) == 0)
                    ctr += dataGridView1[1, i].Value.ToString() + Environment.NewLine;
            }
            if (str.Count() > 1) MessageBox.Show("Имеются просроченные товары!" + Environment.NewLine + "наименование:" + Environment.NewLine + str);
            if (ctr.Count() > 1) MessageBox.Show("Закончились товары!" + Environment.NewLine + "наименование:" + Environment.NewLine + ctr);

            this.Close();
        }

    }
        }
    

