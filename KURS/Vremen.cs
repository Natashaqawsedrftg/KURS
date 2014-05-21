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


using Uprav;

namespace KURS
{
    public partial class Vremen : Form
    {
        public Vremen()
        {
            InitializeComponent();
        }

        private void Vremen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet2.Smotrim' table. You can move, or remove it, as needed.
            this.smotrimTableAdapter.Fill(this.myDBDataSet2.Smotrim);

           


        }

        private void Vremen_FormClosing(object sender, FormClosingEventArgs e)
        {
 //             Class1 u=new Class1(@"C:\Users\User\Desktop\myDB.sdf");
 //             string query = "drop TABLE Smotrim";
 //u.ExecSQL(query);

        }
        public static string stroka="";
        private void button1_Click(object sender, EventArgs e)
        {  
            Vibor v = new Vibor();
            v.Show();
       
            
   
           
                
        }
    }
}
