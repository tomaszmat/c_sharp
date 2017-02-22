using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TomaszMatusiakLab02_06052015
{
    public partial class FormAutoReg : Form
    {
        public FormAutoReg()
        {
            InitializeComponent();
        }

        private void timerAutoReg_Tick(object sender, EventArgs e)
        {
            dataGridViewAutoRegArrivals.Rows.Add("PKL 19879", "Klawiatury", "100");
        }

    }
}
