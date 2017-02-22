using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PPZM
{
    public partial class FormMain : Form
    {
        private double force;
        private double exp;
        private double resExp;
        private const double div = 20.0f;
        private double young;
        private double nextAfterDiv;
        private double llong;
        private double[] arrayOfArguments;
        private double[] arrayOfResults;

        public FormMain()
        {
            InitializeComponent();
            arrayOfArguments = new double[21];
            arrayOfResults = new double[22];
            arrayOfArguments[0] = 0;
            
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double number; int num; 
            if (Double.TryParse(textBoxForce.Text, out number) == false || Double.TryParse(textBoxTgmax.Text, out number) == false || Int32.TryParse(textBoxExponenta.Text, out num) == false ||Double.TryParse(textBoxYoung.Text, out number) == false ||Double.TryParse(textBoxLong.Text, out number) == false || textBoxForce.Text == String.Empty || textBoxLong.Text == String.Empty || textBoxYoung.Text == String.Empty)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                checkAndDo();
            
        }
         private void checkAndDo()
        {
            dataGridViewCalcData.Rows.Clear();
            dataGridViewCalcData.Refresh();
            exp = Double.Parse(textBoxExponenta.Text);
            resExp = Math.Pow(10, exp);
            force = Double.Parse(textBoxForce.Text);
            llong = Double.Parse(textBoxLong.Text);
            young = Double.Parse(textBoxYoung.Text);
            nextAfterDiv = llong / div;
            arrayOfResults[0] = calcFunction(0);
            arrayOfResults[21] = calcFunction(llong);
            for (int i = 1; i <= 20; i++)
            {
                arrayOfArguments[i] = arrayOfArguments[i - 1] + nextAfterDiv;
                arrayOfResults[i] = calcFunction(arrayOfArguments[i]);
                dataGridViewCalcData.Rows.Add(arrayOfResults[i], arrayOfArguments[i]);
            }
            makeChart();
        }

        private double calcFunction(double argument)
        {
            double rresult = (force*argument*argument*(llong-argument)* (llong - argument)) /(2*young*resExp*llong * llong);
            double thisResult = rresult *(1- 2*argument/llong);
            return thisResult;
        }

        private void buttonExcelExport_Click(object sender, EventArgs e)
        {
            
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                excelApp.Workbooks.Add();
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
                workSheet.Cells[1, "A"] = "tg a";
                workSheet.Cells[1, "B"] = "b";
                for (int i = 0; i < 21; i++)
                {
                    excelApp.Cells[i+2, "A"] = arrayOfResults[i];
                    excelApp.Cells[i+2, "B"] = arrayOfArguments[i]; ;
                }
                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();
                
        }

        private void buttonCleanDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void makeChart()
        {

            chart1.Series["tg a = f(l)"].Points.Clear();
            chart1.Series["+tg a max"].Points.Clear();
            chart1.Series["-tg a max"].Points.Clear();

            double tempToChart = Double.Parse(textBoxTgmax.Text);
            for (int i = 0; i < 20; i++)
            {
                chart1.Series["tg a = f(l)"].Points.AddXY(arrayOfArguments[i], arrayOfResults[i]);
                chart1.Series["+tg a max"].Points.AddXY(arrayOfArguments[i], tempToChart);
                chart1.Series["-tg a max"].Points.AddXY(arrayOfArguments[i], -tempToChart);
            }
        }
       
    }
}
