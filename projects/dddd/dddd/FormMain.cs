using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;
using Excel = Microsoft.Office.Interop.Excel;

namespace dddd
{
    public partial class FormMain : Form
    {
        SerialPort port;
        char[] charsToTrim = { 'V', 'T', 'I', 'r', '/' };
        List<double> voltageVal = new List<double>();
        List<double> currentVal = new List<double>();
        List<double> powerVal = new List<double>();
        List<double> timeList = new List<double>();
        List<double> voltageValMin = new List<double>();
        List<double> voltageValMax = new List<double>();

        public FormMain()
        {
            InitializeComponent();
            refreshComs();
            numericUpDown2.Maximum = 5001;
            numericUpDown2.Value = 100;
            zedGraphControlGraph.GraphPane.Title = "U = f(t)";
            zedGraphControlGraph.GraphPane.YAxis.Title = "Napięcie [V]";
            zedGraphControlGraph.GraphPane.XAxis.Title = "Czas";

            zedGraphControlGraph2.GraphPane.Title = "I = f(t)";
            zedGraphControlGraph2.GraphPane.YAxis.Title = "Prąd [A]";
            zedGraphControlGraph2.GraphPane.XAxis.Title = "Czas";

            zedGraphControlGraph3.GraphPane.Title = "P = f(t)";
            zedGraphControlGraph3.GraphPane.YAxis.Title = "Moc [W]";
            zedGraphControlGraph3.GraphPane.XAxis.Title = "Czas";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string com = comboBoxPorts.Text.ToString();
            port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            timerGraph.Start();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            make(indata);
        }


        int cyf = 1;
        int czy = 0;
        double u = 0.0;
        double i = 0.0;
        double p = 0.0;

        private void make(string data)
        {
            
            

            string x = data;
            
            if (czy >1)
            {
                p = u * i;
               
               textBoxPower.Invoke(new Action(delegate ()
              { 
                textBoxPower.Text = String.Empty;
              //  string xan = Convert.ToString(p);
              // textBoxPower.Text = p.ToString();
              textBoxPower.AppendText(p.ToString());
                    voltageVal.Add(u);
                    currentVal.Add(i);
                    powerVal.Add(p);
                    timeList.Add(cyf);
                    cyf++;
                   

                }));

                
            }

            if (data.Contains("V"))
            {
                
                textBoxVoltage.Invoke(new Action(delegate ()
                {
                    textBoxVoltage.Text = String.Empty;
                    string v = x.Trim(charsToTrim);
                    int vi = v.Length;
                    v = v.Remove(vi - 1);
                    v = v.Replace('.', ',');
                    textBoxVoltage.AppendText(v);
                    u =Double.Parse(textBoxVoltage.Text);
                    czy++;
                }));
            }

            else if(data.Contains("I"))
            {
                
                textBoxCurrent.Invoke(new Action(delegate ()
                {
                    textBoxCurrent.Text = String.Empty;
                    string cr = x.Trim(charsToTrim);
                    int ii = cr.Length;
                    cr = cr.Remove(ii - 1);
                    cr = cr.Replace('.', ',');
                    textBoxCurrent.AppendText(cr);
                     i = Convert.ToDouble(textBoxCurrent.Text);
                    czy++;
                }));
                
            }
            else if(data.Contains("T"))
            {
                
                textBoxTemp.Invoke(new Action(delegate ()
                {
                    textBoxTemp.Text = String.Empty;
                    string temp = x.Trim(charsToTrim);
                    temp = temp.Replace('.', ',');
                    textBoxTemp.AppendText(temp);
                }));
                
            }
        
            
        }



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            port.Write((trackBar1.Value).ToString());
        }


        private void updateGraph()
        {
            long len = voltageVal.LongCount();
            int leng = Convert.ToInt32(len);
            double[] helper = new double[leng];
            double[] helper2 = new double[leng];
            double[] helper3 = new double[leng];
            double[] timer = new double[leng];

            double[] helper01 = new double[leng];
            double[] helper02 = new double[leng];

            double volMid = 0.0;
            double curMid = 0.0;
            double powMid = 0.0;

            for (int k = 1; k < leng; k++)
            {
                helper[k] = voltageVal[k];
                volMid += voltageVal[k];
                helper01[k] = voltageVal[k] - voltageVal[k] * 0.001875;
                helper01[k] = voltageVal[k] + voltageVal[k] * 0.001875;


                helper2[k] = currentVal[k];
                curMid += currentVal[k];
               

                helper3[k] = powerVal[k];
                powMid += powerVal[k];
               

                timer[k] = timeList[k];
            }
            volMid /= leng;
            curMid /= leng;
            powMid /= leng;

            textBoxCurMid.Text = Math.Round(curMid,2).ToString();
            textBoxPowMid.Text = Math.Round(powMid, 2).ToString();
            textBoxVolMid.Text = Math.Round(volMid, 2).ToString();

            zedGraphControlGraph.GraphPane.CurveList.Clear();
            CurveItem linia = zedGraphControlGraph.GraphPane.AddCurve("", timer, helper, Color.Aqua, SymbolType.Circle);
            zedGraphControlGraph.GraphPane.AxisChange();
            zedGraphControlGraph.Invalidate();

            zedGraphControlGraph2.GraphPane.CurveList.Clear();
            CurveItem linia2 = zedGraphControlGraph2.GraphPane.AddCurve("", timer, helper2, Color.DarkMagenta, SymbolType.XCross);
            zedGraphControlGraph2.GraphPane.AxisChange();
            zedGraphControlGraph2.Invalidate();


            zedGraphControlGraph3.GraphPane.CurveList.Clear();
            CurveItem linia3 = zedGraphControlGraph3.GraphPane.AddCurve("", timer, helper3, Color.CornflowerBlue, SymbolType.Circle);
            zedGraphControlGraph3.GraphPane.AxisChange();
            zedGraphControlGraph3.Invalidate();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            updateGraph();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            zedGraphControlGraph.GraphPane.CurveList.Clear();
            zedGraphControlGraph2.GraphPane.CurveList.Clear();
            zedGraphControlGraph3.GraphPane.CurveList.Clear();
        }

        private void buttonDiscon_Click(object sender, EventArgs e)
        {
            port.Close();
        }


        private void buttonOpenExcel_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "Napięcie [V]";
            workSheet.Cells[1, "B"] = "Prąd [A]";
            workSheet.Cells[1, "C"] = "Pomiar";
            for (int i = 1; i < voltageVal.LongCount(); i++)
            {
                excelApp.Cells[i + 1, "A"] =voltageVal[i];
                excelApp.Cells[i + 1, "B"] = currentVal[i];
                excelApp.Cells[i + 1, "C"] = timeList[i];
            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();

        }

        private void buttonChangeFreq_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 50 && numericUpDown2.Value < 5000)
                port.Write((numericUpDown2.Value).ToString());
            else
                MessageBox.Show("Wartość nie mieści się w przedziale (50,5000) [ms]", "Niepoprawna wartość");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshComs();
        }

        private void refreshComs()
        {
            string[] mojePorty = SerialPort.GetPortNames();
            foreach (string port in mojePorty)
            {
                comboBoxPorts.Items.Add(port);
            }
        }

        private void timerGraph_Tick(object sender, EventArgs e)
        {
            updateGraph();
        }
    }
}
