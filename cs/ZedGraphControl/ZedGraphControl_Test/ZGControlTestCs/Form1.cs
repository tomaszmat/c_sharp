using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ZedGraph;

namespace WindowsApplication2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		ZedGraph.ZedGraphControl zedGraphControl1;
		ZedGraph.GraphPane   myPane;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
			this.SuspendLayout();
			// 
			// zedGraphControl1
			// 
			this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
			this.zedGraphControl1.Name = "zedGraphControl1";
			this.zedGraphControl1.Size = new System.Drawing.Size(680, 414);
			this.zedGraphControl1.TabIndex = 0;
			this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 414);
			this.Controls.Add(this.zedGraphControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void zedGraphControl1_Load(object sender, System.EventArgs e)
		{
			zedGraphControl1.GraphPane.Title = "Test Case for C#";
	/*		double[] x = new double[100];
			double[] y = new double[100];
			int	i;
			for ( i=0; i<100; i++ )
			{
				x[i] = (double) i / 100.0 * Math.PI * 2.0;
				y[i] = Math.Sin( x[i] );
			}
			zedGraphControl1.GraphPane.AddCurve( "Sine Wave", x, y, Color.Red, SymbolType.Square );
			zedGraphControl1.GraphPane.AxisChange();
	*/
			// Create a new graph with topLeft at (40,40) and size 600x400
			myPane = new GraphPane( new Rectangle( 40, 40, 600, 400 ),
				"My Test Graph\n(For CodeProject Sample)",
				"My X Axis",
				"My Y Axis" );
			myPane.Title="asd";

			// Make up some random data points
			double[] x = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
			double[] y = { 20, 10, 50, 40, 35, 60, 90, 25, 48, 75 };
			// Generate a red curve with diamond
			// symbols, and "My Curve" in the legend
			CurveItem myCurve = myPane.AddCurve( "My Curve",
				x, y, Color.Red, SymbolType.Diamond );
			// Tell ZedGraph to refigure the
			// axes since the data have changed
			myPane.AxisChange();

		}
	}
}
