using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Mars_Mission_Control_Dev
{
	public partial class TestSam : Form
	{
		private Carte carte = new Carte();
		
		
		public TestSam()
		{
			InitializeComponent();

			this.lbTailleImage.Text = "Taille : " + carte.ImageZone.Width + " par " + carte.ImageZone.Height + " pixels";
			//this.pictureBox1.Cursor

			this.pictureBox1.Width = 300;
			this.pictureBox1.Height = 561;

			Image img = (Image)carte.ImageZone.Clone();
			img = new Bitmap(img, new Size(this.pictureBox1.Width,this.pictureBox1.Height));

						
			this.pictureBox1.Image = img;


			//pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			//pictureBox1.Location = new Point(0, 0);

			using (Graphics gr = Graphics.FromImage(this.pictureBox1.Image))
			{
				//gr.SmoothingMode = SmoothingMode.AntiAlias;

				//gr.DrawIcon(Icon Icon,int x, int y);
				//gr.DrawImage();
				
				Rectangle rect = new Rectangle(10, 50, 1, 1);
						
				using (Pen petitCrayon = new Pen(Color.Blue, 1))
				{
					gr.DrawRectangle(petitCrayon, rect);
				}
			}

			//pictureBox1.Image = img;

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
