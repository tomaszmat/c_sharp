using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;

namespace RadioTerminal.Controler
{

    public class Communication
    {
        /* FOR MCU		
     
        string _Reset = "xxC00RES";
        string Set1200 = "AT+B1200";
        string Set2400 = "AT+B2400";
        string Set4800 = "AT+B4800";
        string Set9600 = "AT+B9600";
        string Set19200 = "AT+B19200";
        string Set38400 = "AT+B38400";
        string Set57600 = "AT+B57600";
        string Set115200 = "AT+B115200";

        string HC_CHANNEL_01 = "HC0CH001";
        string HC_CHANNEL_02 = "HC0CH002";
        string HC_CHANNEL_03 = "HC0CH003"; 
        string HC_CHANNEL_04 = "HC0CH004";

        public string HC_INFO = "HC0V0000"; 
        public string HC_Check = "HC0C0000"; */
    }
}

//this.Close();
//port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
//port.Open();
//port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
//Form
//formMain.Show();
//form.Close();

/*
 private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            //make(indata);
        }
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

    */
