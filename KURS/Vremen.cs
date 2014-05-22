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
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;


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
            // TODO: This line of code loads data into the 'myDBDataSet.Smotrim' table. You can move, or remove it, as needed.
            this.smotrimTableAdapter.Fill(this.myDBDataSet.Smotrim);
           

           


        }

        private void Vremen_FormClosing(object sender, FormClosingEventArgs e)
        {
 //             Class1 u=new Class1(@"C:\Users\User\Desktop\myDB.sdf");
 //             string query = "drop TABLE Smotrim";
 //u.ExecSQL(query);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            Paragraph a1 = new Paragraph();
            a1.Alignment = Element.ALIGN_LEFT;
            a1.SpacingAfter = 20;
            a1.Add(new Phrase("firma kosmetics", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            a1.Add(Environment.NewLine + Environment.NewLine);
            a1.Add(new Phrase("Ulyanovsk, Russian Federation", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            a1.Add(Environment.NewLine);

            Paragraph a2 = new Paragraph();
            a2.Alignment = Element.ALIGN_CENTER;
            a2.SpacingAfter = 20;
            a2.Add(new Phrase("Рекомендуемый товар ", new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            a2.Add(new Phrase(" от " + System.DateTime.Now.Date.ToShortDateString() + " г.", new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            a2.Add(Environment.NewLine);

            PdfPTable table = new PdfPTable(3);
            table.HorizontalAlignment = Element.ALIGN_MIDDLE;

            table.AddCell(new Phrase("ID", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("наименование", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("цена", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));

            allDataSet ds = new allDataSet();
            allDataSetTableAdapters.TovarTableAdapter ta = new allDataSetTableAdapters.TovarTableAdapter();
            ta.Fill(ds.Tovar);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var d = from price in ds.Tovar.AsEnumerable() where price.Field<string>("name") == dataGridView1[1, i].Value.ToString() select price;
                foreach (var obj in d)
                {
                    table.AddCell(new Phrase(obj.id.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(obj.name.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(obj.price.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                }
                var d2 = from price in ds.Tovar.AsEnumerable() where price.Field<string>("name") == dataGridView1[2, i].Value.ToString() select price;
                foreach (var obj in d2)
                {
                    table.AddCell(new Phrase(obj.id.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(obj.name.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(obj.price.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                }
                var d3 = from price in ds.Tovar.AsEnumerable() where price.Field<string>("name") == dataGridView1[3, i].Value.ToString() select price;
                foreach (var obj in d3)
                {
                    table.AddCell(new Phrase(obj.id.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(obj.name.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(new Phrase(obj.price.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                }
            }

            Paragraph a6 = new Paragraph(new Phrase("Подпись продавца:_____________", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            a6.Alignment = Element.ALIGN_LEFT;
            a6.SpacingBefore = 40;

            doc.Add(a1);
            doc.Add(a2);
            doc.Add(table);
            doc.Add(a6);
            doc.Close();
            MessageBox.Show("Файл сохранен!");

            //System.Diagnostics.Process command = new System.Diagnostics.Process();
            //command.StartInfo.FileName = @"C:\Program Files\Adobe\Reader 11.0\Reader\acrord32.exe";
            //command.StartInfo.Arguments = saveFileDialog1.FileName;
            //command.Start();
            //command.WaitForExit(3100);
            //command.Close();
            Vibor v = new Vibor();
            v.Show();
        }

       
    }
}
