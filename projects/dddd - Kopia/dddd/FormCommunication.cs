using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioTerminal
{
    
    public partial class FormCommunication : Form
    {
        SerialPort port;
        string com;
        public FormCommunication(string _com)
        {
            com = _com;
            InitializeComponent();
            panelRadio.Enabled = false;
            panelSend.Enabled = false;
            panelSettings.Enabled = true;
            
           
            port = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler); 
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            HandleData(indata);
        }

        private void radioButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            panelRadio.Enabled = true;
            panelSend.Enabled = true;
            panelSettings.Enabled = false;
        }

        private void radioButtonSettings_CheckedChanged(object sender, EventArgs e)
        {
            panelRadio.Enabled = false;
            panelSend.Enabled = false;
            panelSettings.Enabled = true;
        }

        private void HandleData(string _data)
        {
            listBoxRecived.Invoke(new Action
                                    (delegate ()
                                        {

                                            listBoxRecived.Items.Add(_data);

                                        }
                                    )
                                );
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBoxSend.Text != String.Empty)
            {
                port.WriteLine(textBoxSend.Text);
                textBoxSend.Text = String.Empty;
                listBoxSended.Items.Add(textBoxSend.Text);
            }
        }

        public string HC_INFO = "HC0V0000";
        public string HC_Check = "HC0C0000";
        string _Reset = "xxC00RES";

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            port.WriteLine(HC_INFO);

            port.WriteLine(HC_Check);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            port.WriteLine(_Reset);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            port.Close();
            this.Close();
        }
    }
}
