using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumerationen
{
	public partial class Form1 : Form
	{
		private enum Farbe : int
		{
			Rot = 1, Gelb = 2, Blau = 3
		}
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEnumeration1_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text = "Farbe: " + Farbe.Gelb 
				+ " " + (int)Farbe.Gelb;
		}

		private void btnEnumeration2_Click(object sender, EventArgs e)
		{
			lblAnzeige.Text = "Sonntag: " + DayOfWeek.Sunday + " " +
				(int)DayOfWeek.Sunday + "\n"
				+ "Samstag: " + DayOfWeek.Saturday +
				" " + (int)DayOfWeek.Saturday;
		}
	}
}
