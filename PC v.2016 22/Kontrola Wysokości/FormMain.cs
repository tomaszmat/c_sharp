using System;
using System.IO.Ports;
using System.Windows.Forms;


namespace control
{
    public partial class FormMain : Form
    {
      
        SerialPort ArduinoPort; 
        public FormMain()
        {
            InitializeComponent();
            groupBoxParameters.Enabled = false;
            groupBoxSort.Enabled = false; 
            buttonDiscon.Enabled = false; 
            buttonChangeWithAccept.Enabled = false;
            buttonStart.Enabled = false; 
            buttonStop.Enabled = false;
            foreach (String s in SerialPort.GetPortNames()) this.comboBoxCOM.Items.Add(s); 
            comboBoxBaud.Items.Add("2400"); 
            comboBoxBaud.Items.Add("4800");
            comboBoxBaud.Items.Add("9600");
            comboBoxBaud.Items.Add("19200");
        }

        private void buttonCon_Click_1(object sender, EventArgs e)
        {
            if (comboBoxBaud.Text == String.Empty || comboBoxCOM.Text == String.Empty)
            {
                MessageBox.Show("Ustaw parametry połączenia!\n (9600)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string com = comboBoxCOM.SelectedItem.ToString(); 
                int baud = Int32.Parse(comboBoxBaud.SelectedItem.ToString());
                ArduinoPort = new SerialPort(com, baud, Parity.None, 8, StopBits.One); 
                ArduinoPort.Handshake = Handshake.None;
                ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived); 
                ArduinoPort.Open();
                MessageBox.Show("Połączenie się udalo", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                groupBoxParameters.Enabled = true;
                groupBoxSort.Enabled = true;
                buttonCon.Enabled = false;
                buttonDiscon.Enabled = true;
                buttonStart.Enabled = true;
                buttonStop.Enabled = true;
            }
        }

        private void buttonDiscon_Click_1(object sender, EventArgs e)
        {
            ArduinoPort.Close();
            buttonCon.Enabled = true;
            buttonDiscon.Enabled = false;
            buttonStart.Enabled = false;
            buttonStop.Enabled = false;
            groupBoxParameters.Enabled = false;
            groupBoxSort.Enabled = false;
        }


        private void checkBoxToCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxToCheck.Checked == true)
            {
                buttonChangeWithAccept.Enabled = true;
            }
        }

        string indata;
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            indata = ArduinoPort.ReadLine(); 
            this.Invoke(new EventHandler(actListBox)); 
        }

        private void actListBox(object sender, EventArgs e)
        {
            listBoxTest.Items.Add(indata);  
        }


        private void buttonChangeWithAccept_Click(object sender, EventArgs e)
        {
            if(checkBoxToCheck.Checked == true)
            {
                if (comboBoxHigh.SelectedIndex == 0)
                {
                    ArduinoPort.Write("3");
                }
                else if (comboBoxHigh.SelectedIndex == 1)
                {
                    ArduinoPort.Write("4");
                }
                else if (comboBoxHigh.SelectedIndex == 2)
                {
                    ArduinoPort.Write("5");
                }
                else if (comboBoxHigh.SelectedIndex == 3)
                {
                    ArduinoPort.Write("0");
                }
                else
                {
                    MessageBox.Show("Nie wybrałeś nic!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }
         
        private void buttonClean_Click(object sender, EventArgs e)
        {
            listBoxTest.Items.Clear();
        }

        private void buttonServo_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("7");
        }

        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("6");
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            foreach (String coms in SerialPort.GetPortNames()) this.comboBoxCOM.Items.Add(coms);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("9");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("8");
        }
    }
}
