using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Mars_Mission_Control
{
    public partial class Form3 : Form
    {
        public Form3(Calendrier calendrier, Journee jourActuel, Activite actiActuelle)
        {
            InitializeComponent();
            this.labelJ.Text = jourActuel.NumJour.ToString();
            this.labelActi.Text = actiActuelle.Descritpion;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelJ_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
