using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AODL.Document.Content.Tables;
using AODL.Document.SpreadsheetDocuments;
using AODL.Document.TextDocuments;
using AODL.Document.Styles;
using AODL.Document.Content.Text;

namespace kursOOPpart2
{
    public partial class Postav : Form
    {
        public Postav()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.Diagnostics.Process command = new System.Diagnostics.Process();
            command.StartInfo.FileName = @"C:\Program Files\Adobe\Reader 11.0\Reader\acrord32.exe";
            command.StartInfo.Arguments = openFileDialog1.FileName;
            command.Start();
            command.WaitForExit(31000);
            command.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            KURS.allDataSet kursDataSet = new KURS.allDataSet();
            KURS.allDataSetTableAdapters.TovarTableAdapter TovarTableAdapter = new KURS.allDataSetTableAdapters.TovarTableAdapter();
            TovarTableAdapter.Fill(kursDataSet.Tovar);

            TextDocument textdocument = new TextDocument();
            textdocument.New();
            Paragraph headerText1 = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
            headerText1.TextContent.Add(new SimpleText(textdocument, "firma kosmetics"));
            textdocument.Content.Add(headerText1);
            Paragraph headerText2 = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
            headerText2.TextContent.Add(new SimpleText(textdocument, "Ulyanovsk, Russian Federation"));
            textdocument.Content.Add(headerText2);
            Paragraph headerText3 = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
            headerText3.TextContent.Add(new SimpleText(textdocument, "Кому: " + listBox1.Text));
            textdocument.Content.Add(headerText3);

            var d = from price in kursDataSet.Tovar.AsEnumerable() where price.kolvo == 0 select price;
            Paragraph maintext = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
            maintext.TextContent.Add(new SimpleText(textdocument, "ID--name--srok--price"+Environment.NewLine));
            textdocument.Content.Add(maintext);
            foreach (var obj in d)
            {
                Paragraph maintext2 = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
                maintext2.TextContent.Add(new SimpleText(textdocument, obj.id.ToString() + "--" + obj.name.ToString() + "--" + obj.srok.ToString() + "--" + obj.price.ToString() + Environment.NewLine));
                textdocument.Content.Add(maintext2);
            }
            
            Paragraph footerText = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
            footerText.TextContent.Add(new SimpleText(textdocument, "Подпись продавца:_____________"));
            textdocument.Content.Add(footerText);
            textdocument.SaveTo(saveFileDialog1.FileName);
        }

        private void Postav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet2.Cater". При необходимости она может быть перемещена или удалена.
            //this.caterTableAdapter.Fill(this.myDBDataSet2.Cater);

        }
    }
}
