using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;


namespace kursOOPpart2
{
    public partial class CreateForClient : Form
    {
        public CreateForClient()
        {
            InitializeComponent();
        }

        private void CreateForClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataSet.Zakaz' table. You can move, or remove it, as needed.
            this.zakazTableAdapter.Fill(this.allDataSet.Zakaz);
            // TODO: This line of code loads data into the 'allDataSet.Tovar' table. You can move, or remove it, as needed.
            this.tovarTableAdapter.Fill(this.allDataSet.Tovar);
            // TODO: This line of code loads data into the 'allDataSet.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.allDataSet.Klient);
            // TODO: This line of code loads data into the 'allDataSet.Haracteristiki' table. You can move, or remove it, as needed.
            this.haracteristikiTableAdapter.Fill(this.allDataSet.Haracteristiki);
            // TODO: This line of code loads data into the 'allDataSet.Caterer' table. You can move, or remove it, as needed.
            this.catererTableAdapter.Fill(this.allDataSet.Caterer);
            // TODO: This line of code loads data into the 'allDataSet.Klient' table. You can move, or remove it, as needed.
            this.klientTableAdapter.Fill(this.allDataSet.Klient);
            // TODO: This line of code loads data into the 'allDataSet.Haracteristiki' table. You can move, or remove it, as needed.
            this.haracteristikiTableAdapter.Fill(this.allDataSet.Haracteristiki);
            // TODO: This line of code loads data into the 'allDataSet.Caterer' table. You can move, or remove it, as needed.
            this.catererTableAdapter.Fill(this.allDataSet.Caterer);
         
           
            label8.Text = System.DateTime.Now.Date.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            a2.Add(new Phrase("РАСХОДНАЯ НАКЛАДНАЯ № ", new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            a2.Add(new Phrase(allDataSet.Zakaz.Rows.Count.ToString(), new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.UNDERLINE, new BaseColor(Color.Black))));
            a2.Add(new Phrase(" от " + label8.Text + " г.", new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            a2.Add(Environment.NewLine);

            Paragraph a3 = new Paragraph();
            a3.Alignment = Element.ALIGN_LEFT;
            a3.SpacingAfter = 20;
            a3.Add(new Phrase("Кому: ", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            a3.Add(new Phrase(listBox3.Text, new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.UNDERLINE, new BaseColor(Color.Black))));
            a3.Add(Environment.NewLine);

            PdfPTable table = new PdfPTable(6);
            table.HorizontalAlignment = Element.ALIGN_MIDDLE;

            table.WidthPercentage = 109;
            table.SetWidths(new int[6] { 19, 18, 18, 18, 18, 18 });

            table.AddCell(new Phrase("наименование", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("количество", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("цена", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("сумма", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("процент скидки", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));
            table.AddCell(new Phrase("итого", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black))));

            Paragraph a5 = new Paragraph();

            var d = from price in allDataSet.Tovar.AsEnumerable() where price.Field<int>("ID") == Convert.ToInt32(listBox1.SelectedValue) select price;
            foreach (var obj in d)
            {
                table.AddCell(new Phrase(obj.name.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                table.AddCell(new Phrase(textBox2.Text, new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                table.AddCell(new Phrase(obj.price.ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                table.AddCell(new Phrase(Math.Round((Convert.ToInt32(textBox2.Text) * Convert.ToDouble(obj.price)),2).ToString(), new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            }     
            table.AddCell(new Phrase(label9.Text, new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            table.AddCell(new Phrase(label10.Text, new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            a5.Add(new Phrase("К оплате " + label10.Text+" рублей", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            a5.Alignment = Element.ALIGN_LEFT;
            a5.SpacingBefore = 40;

            Paragraph a6 = new Paragraph(new Phrase("Подпись продавца:_____________", new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
            a6.Alignment = Element.ALIGN_LEFT;
            a6.SpacingBefore = 40;

            doc.Add(a1);
            doc.Add(a2);
            doc.Add(a3);
            doc.Add(table);
            doc.Add(a5);
            doc.Add(a6);
            doc.Close();
            MessageBox.Show("Файл сохранен!");

            System.Diagnostics.Process command = new System.Diagnostics.Process();
            command.StartInfo.FileName = @"C:\Program Fi\686н99999999999999999999999999999999999999999999999es\Adobe\Reader 11.0\Reader\acrord32.exe";
            command.StartInfo.Arguments = saveFileDialog1.FileName;
            command.Start();
            command.WaitForExit(3100);
            command.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf; "))
            {
                conn.Open();
                using (SqlCeCommand c = new SqlCeCommand(@"insert into Zakaz(Data, IDtovar, kolvo, SummSkidk, Summ, IDpostav, IDklient) values('" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Convert.ToInt32(listBox1.SelectedValue) + "," + Convert.ToInt32(textBox2.Text) + "," + label9.Text.Replace(',', '.') + "," + label10.Text.Replace(',', '.') + "," + Convert.ToInt32(listBox2.SelectedValue) + "," + Convert.ToInt32(listBox3.SelectedValue) + ")"))
                {
                    c.Connection = conn;
                    c.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Значение добавлено!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double summ=0;
            var d = from price in allDataSet.Tovar.AsEnumerable() where price.Field<int>("id") == Convert.ToInt32(listBox1.SelectedValue) select price;
            foreach (var obj in d)
            {
                summ = Convert.ToDouble(obj.price) * Convert.ToInt32(textBox2.Text);
                SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\Андрей свали с компа\Desktop\myDB.sdf");
                conn.Open();
                using (SqlCeCommand c = new SqlCeCommand(@"update Tovar set kolvo=" + (obj.kolvo - Convert.ToInt32(textBox2.Text)).ToString() + " where id="+obj.id))
                {
                    c.Connection = conn;
                    c.ExecuteNonQuery();
                }
                conn.Close();
            }
            kursOOPpart2.Skidka sk = new kursOOPpart2.Skidka(summ);
            sk.ShowDialog();
            label9.Text = (sk.met()/100).ToString();
            label10.Text = Math.Round((summ-summ*Convert.ToDouble(label9.Text)),2).ToString();
        }

    }
}