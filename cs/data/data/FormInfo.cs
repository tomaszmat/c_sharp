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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Paint(object sender, PaintEventArgs e)
        {
            Pen penLinesY = new Pen(Color.GreenYellow, 1f);
            Pen penLinesX = new Pen(Color.BlueViolet, 2f);
            Graphics graphLinesY = e.Graphics;
            Graphics graphLinesX = e.Graphics;
            graphLinesY.DrawLine(penLinesY, 76, 300, 76, 20);
            graphLinesY.DrawLine(penLinesY, 276, 300, 276, 20);
            graphLinesX.DrawLine(penLinesX, 76, 300, 276, 300);
            graphLinesX.DrawLine(penLinesX, 76, 20, 276, 20);
        }

        
    }
}
