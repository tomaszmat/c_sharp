using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tomaszMatusiak
{
    public partial class FormLinq : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public FormLinq()
        {
            InitializeComponent();
        }

        private void bTest1_Click(object sender, EventArgs e)
        {
            var query = from c in dc.Products select c;
            DgvView.DataSource = query;
        }

      

    }
}
