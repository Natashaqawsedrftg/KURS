using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Data.Linq;

namespace KURS
{
    public partial class Vibor : Form
    {
        public Vibor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klient k = new Klient();
            k.Show();
            
        }

       

 

        private void button2_Click(object sender, EventArgs e)
        { string s = @"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf";
                SqlCeDataAdapter da = new SqlCeDataAdapter("Select * from Klient", s);
                DataSet ds = new DataSet();
                da.Fill(ds, "Klient");

                DataTable dt = ds.Tables["Klient"];
                var q = dt.AsEnumerable()
                    .Where(t => t.Field<int>("id") == Convert.ToInt32(textBox1.Text))
                        .Select(t => t);
                foreach (var i in q)
                { Mail.Message(i.Field<string>("email")); }
                this.Close();
                //foreach (var i in q)
                //{
                //    MessageBox.Show(i.Field<int>("id") + "   " + i.Field<string>("SIF"));
                //}
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }

      
    }

