//using RadioTerminal;
using System;
using System.Windows.Forms;


namespace RadioTerminal
{
    public partial class FormBegin : Form
    {
       
        public FormBegin()
        {
            InitializeComponent();
            refreshComs();
            textBoxLogin.Text = "admin";
            textBoxPassword.Text = "admin";
          
        }

        #region Connect

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if ((comboBoxPorts.Text.ToString()) != String.Empty)
            {
                string PortCom = comboBoxPorts.Text.ToString();
                FormCommunication formCom = new FormCommunication(PortCom);
                formCom.Show();
                this.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Choose COM!", "Valid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Refreshing avaible com ports
        private void refreshComs()
        {
           string[] mojePorty = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in mojePorty)
            {
                comboBoxPorts.Items.Add(port);
            }
        }
        #endregion

        private void comboBoxPorts_Click(object sender, EventArgs e) //Refresh when someone clicked comboBox
        {
            refreshComs();
        }


    }
}
