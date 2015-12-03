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
    public partial class Form3 : Form
    {
        public Form2 parent;
        public Journee jourActuel;
        public Activite actiActuelle;
        public System.Drawing.Graphics graphics;

        public Form3(Form2 p, Calendrier calendrier, Journee jourActuel, Activite actiActuelle)
        {
            InitializeComponent();

            if (actiActuelle != null)
            {
                this.H_debut.SelectedItem = actiActuelle.HeureDebut.Heure.ToString();
                this.M_debut.SelectedItem = actiActuelle.HeureDebut.Minute.ToString();
                this.H_fin.SelectedItem = actiActuelle.HeureFin.Heure.ToString();
                this.M_fin.SelectedItem = actiActuelle.HeureFin.Minute.ToString();
                this.description.SelectedText = actiActuelle.Descritpion.ToString();
                this.labelActi.Text = actiActuelle.Nom;
                this.textBoxX.Text = string.Format("{0}", actiActuelle.Lieu.Position.X);
                this.textBoxY.Text = string.Format("{0}", actiActuelle.Lieu.Position.Y);
            }
            else
            {
                btn_suppr.Enabled = false;
            }
            this.jour_actuel.Text = jourActuel.NumJour.ToString();
            this.jourActuel = jourActuel;
            this.actiActuelle = actiActuelle;

            parent = p;

            graphics = pictureBox1.CreateGraphics();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        #region methode de verification
        private bool verifieDonnees(List<Activite> listActi, Activite tmpActi)
        {
            if ((tmpActi.HeureDebut.Heure * 60 + tmpActi.HeureDebut.Minute) > (tmpActi.HeureFin.Heure * 60 + tmpActi.HeureFin.Minute))
            {
                return false;
            }
            bool res = true;
            foreach (var item in listActi)
            {
                if (item != actiActuelle)
                {
                    // heure de début de la nouvelle activité > heure de début d'une ancienne
                    if ((tmpActi.HeureDebut.Heure * 60 + tmpActi.HeureDebut.Minute) > (item.HeureDebut.Heure * 60 + item.HeureDebut.Minute))
                    {
                        // heure de début de la nouvelle activité > heure de fin d'une ancienne
                        if (!((tmpActi.HeureDebut.Heure * 60 + tmpActi.HeureDebut.Minute) >= (item.HeureFin.Heure * 60 + item.HeureFin.Minute)))
                        {
                            res = false;
                        }
                    }
                    // heure de début de la nouvelle activité < heure de début d'une ancienne
                    else
                    {
                        // heure de fin de la nouvelle activité < heure de début d'une ancienne
                        if (!((tmpActi.HeureFin.Heure * 60 + tmpActi.HeureFin.Minute) <= (item.HeureDebut.Heure * 60 + item.HeureDebut.Minute)))
                        {
                            res = false;
                        }
                    }
                }
            }
            return res;
        }

        private bool testCoord(string coord, out int valeur, int coordMin, int coordMax)
        {
            bool res = int.TryParse(coord, out valeur);
            if (coordMin > valeur || coordMax < valeur)
                res = false;
            return res;
        }

        private bool testTreeView()
        {
            return treeView1.SelectedNode.Nodes.Count == 0;
        }
        #endregion

        #region evenement
        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            bool PossibleDeChanger = true;

            Dates datesDebut = new Dates(jourActuel.NumJour, int.Parse(H_debut.Text), int.Parse(M_debut.Text));
            Dates datesFin = new Dates(jourActuel.NumJour, int.Parse(H_fin.Text), int.Parse(M_fin.Text));

            //verif des coordonnées
            int cooX, cooY;
            if (!testCoord(textBoxX.Text, out cooX, 0, 1000))
                PossibleDeChanger = false;
            if (!testCoord(textBoxY.Text, out cooY, 0, 1000))
                PossibleDeChanger = false;

            Coordonnees coo = new Coordonnees(nom_position.Text, new Point(cooX, cooY));
            Activite tmpActi = new Activite(treeView1.SelectedNode.Text, datesDebut, datesFin, coo, description.Text, jourActuel.ListActiviteJournee[0].ListSpationaute); //attention a l'assignation des Spationautes
            //verif des données
            if (!verifieDonnees(jourActuel.ListActiviteJournee, tmpActi))
                PossibleDeChanger = false;

            //verif le treeView
            if (!testTreeView())
                PossibleDeChanger = false;

            if (PossibleDeChanger)
            {
                jourActuel.ListActiviteJournee.Remove(actiActuelle);
                jourActuel.ListActiviteJournee.Add(tmpActi);
                actiActuelle = tmpActi;
                this.Close();
            }
            else
            {
                PopUp_ModifImpossible popup = new PopUp_ModifImpossible();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // labelActi.Text = treeView1.SelectedNode.Text;
        }

        private void H_debut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 24)
            {
                M_debut.Items.Remove(50);
            }
            else
            {
                if (!M_debut.Items.Contains(50))
                    M_debut.Items.Add(50);
            }
        }

        private void H_fin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 24)
            {
                M_fin.Items.Remove(50);
            }
            else
            {
                if (!M_fin.Items.Contains(50))
                    M_fin.Items.Add(50);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            MouseEventArgs eM = (MouseEventArgs)e;
            int taille = 50;
            Image patate = Image.FromFile("../../../patate.png");
            patate = (Image)(new Bitmap(patate, new Size(taille, taille)));
            Point p = new Point(eM.Location.X - taille / 2, eM.Location.Y - taille / 2);


            textBoxX.Text = string.Format("{0}", eM.Location.X - taille / 2);
            textBoxY.Text = string.Format("{0}", eM.Location.Y - taille / 2);
            graphics.DrawImage(patate, p);
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            jourActuel.ListActiviteJournee.Remove(actiActuelle);
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.journee = this.jourActuel;
            parent.rafraichirPage(jourActuel.NumJour);
        }
        #endregion
    }
}
