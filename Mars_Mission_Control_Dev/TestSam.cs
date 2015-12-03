using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mars_Mission_Control_Dev
{
	public partial class TestSam : Form
	{
		private Carte carte = new Carte("./..//..//nanedi_valles.jpg");
		
		
		public TestSam()
		{
			InitializeComponent();

			this.lbTailleImage.Text = "Taille : " + carte.ImageZone.Width + " par " + carte.ImageZone.Height + "pixesl";						
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void TestSam_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			carte.selectCoord(int.Parse(tbX.Text), int.Parse(tbY.Text));
		}
	}
}
