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
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;


namespace kursOOPpart2
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void createKlient_Click(object sender, EventArgs e)
        {
            CreateForClient c = new CreateForClient();
            c.ShowDialog();
        }

        private void createost_Click(object sender, EventArgs e)
        {
            Postav p = new Postav();
            p.ShowDialog();
        }

        private void diagram_Click(object sender, EventArgs e)
        {
            KURS.allDataSet kursds = new KURS.allDataSet();
            KURS.allDataSetTableAdapters.ZakazTableAdapter zta = new KURS.allDataSetTableAdapters.ZakazTableAdapter();
            zta.Fill(kursds.Zakaz);
            //
            object misValue = System.Reflection.Missing.Value;
            //
            Excel.Application excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(misValue);
            Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
            Excel.Workbook excelappworkbook = excelappworkbooks[1];
            Excel.Sheets excelsheets = excelappworkbook.Worksheets;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            //excelworksheet.Activate();
            //
            var c = from p in kursds.Zakaz.AsEnumerable()where p.Data.Month==dateTimePicker1.Value.Month select p;
            int count=0;
            excelapp.Cells[1][1] = "date";
            excelapp.Cells[2][1] = "summ";
            foreach (var p in c)
            {
                count++;
            }
            //
            int[] a = new int[count]; double[] b = new double[count]; int i = 0; double sum=0;
            while (i < count)
            {
                foreach (var p in c)
                {
                    a[i] = p.Data.Day;
                    if (i == 0) { sum += p.Summ; }
                    if (i > 0)
                    {
                        if (a[i] == a[i - 1]) sum += p.Summ;
                        else { b[i - 1] = sum; sum = p.Summ; i++; }
                    }
                    else  i++; 
                }
                b[i-1] = sum; 
                count = i; i = 0;
                break;
            }
            Dictionary<int, double> dic = new Dictionary<int, double>();
            while (i < count)
            {
                excelapp.Cells[1][i+2] = a[i];
                excelapp.Cells[2][i+2] = b[i];
                dic.Add(a[i], b[i]);
                i++;
            }
            //
            string str = (count+1).ToString();
            //
            //Excel.Window excelWindow = null;
            Excel.Range excelcells = null;
            //Определяем диаграммы как объекты Excel.ChartObjects
            Excel.ChartObjects chartsobjrcts = (Excel.ChartObjects)excelworksheet.ChartObjects(Type.Missing);
            //Добавляем одну диаграмму  в Excel.ChartObjects - диаграмма пока не выбрана, но место для нее выделено в методе Add
            Excel.ChartObject chartsobjrct = chartsobjrcts.Add(100, 40, 300, 300);
            Excel.Chart chartPage = chartsobjrct.Chart;

            excelcells = excelworksheet.get_Range("B1", "B"+str);

            chartPage.SetSourceData(excelcells, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            Excel.Axis axis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlCategory,Excel.XlAxisGroup.xlPrimary);
            
            axis.HasTitle = true;
            axis.AxisTitle.Text = "Data";
            //
            Excel.SeriesCollection seriesCollection = (Excel.SeriesCollection)chartPage.SeriesCollection(Type.Missing);
            Excel.Series series = seriesCollection.Item(1);
            series.XValues =  a;
            //
            excelappworkbook.SaveAs(@"D:\siple.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
			
            excelappworkbook.Close(true, misValue, misValue);
            excelapp.Quit();
            this.chart1.Titles.Add("Отчет за месяц");
            this.chart1.Series[0].Points.Clear();
            Series ser = this.chart1.Series[0];
            ser.LegendText = "Summ";
            foreach (KeyValuePair<int, double> pair in dic)
            {
                ser.Points.AddXY(pair.Key, pair.Value);
            }
            //
            }

        private void print_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.Diagnostics.Process command = new System.Diagnostics.Process();
            command.StartInfo.FileName = @"C:\Program Files\Adobe\Reader 11.0\Reader\acrord32.exe";
            command.StartInfo.Arguments = "/h /p " + openFileDialog1.FileName;
            command.StartInfo.UseShellExecute = false;
            command.StartInfo.CreateNoWindow = true;
            command.Start();
            command.WaitForExit(31000);
            if (!command.HasExited)
                command.Kill();
            else command.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
