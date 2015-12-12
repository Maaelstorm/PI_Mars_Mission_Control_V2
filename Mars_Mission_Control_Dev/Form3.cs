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
        public Journee jourSelec;
        public Activite actiActuelle;
        public System.Drawing.Graphics graphics;
        private Calendrier calendrierActuel;

        public Form3(Form2 p, Calendrier calendrier, Journee jourSelec, Activite actiActuelle)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            this.treeView1.ExpandAll();

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
            this.jour_actuel.Text = jourSelec.NumJour.ToString();
            this.jourSelec = jourSelec;
            this.actiActuelle = actiActuelle;

            this.calendrierActuel = calendrier;

            parent = p;

            graphics = pictureBox1.CreateGraphics();

            desactiverJourPasses();
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

        private bool testCoord(string coord, out double valeur, int coordMin, int coordMax)
        {
            bool res = double.TryParse(coord, out valeur);
            if (coordMin > valeur || coordMax < valeur)
                res = false;
            return res;
        }

        private bool testTreeView()
        {
            return treeView1.SelectedNode == null || treeView1.SelectedNode.Nodes.Count == 0;
        }
        #endregion

        #region Evenement
        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            bool PossibleDeChanger = true;

            Dates datesDebut = null;
            Dates datesFin = null;

            try
            {
                datesDebut = new Dates(jourSelec.NumJour, int.Parse(H_debut.Text), int.Parse(M_debut.Text));
                datesFin = new Dates(jourSelec.NumJour, int.Parse(H_fin.Text), int.Parse(M_fin.Text));       
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erreur : {0}. {1}", ex.Message, "Veuillez renseigner les horaires");
            }
            finally
            {
               
            }

            // Vérification des Horaires
            if (H_debut.Text == "" || M_debut.Text == "" || H_fin.Text == "" || M_fin.Text == "")
            {
                PossibleDeChanger = false;
            }
            else
            {
                datesDebut = new Dates(jourSelec.NumJour, int.Parse(H_debut.Text), int.Parse(M_debut.Text));
                datesFin = new Dates(jourSelec.NumJour, int.Parse(H_fin.Text), int.Parse(M_fin.Text));                        
            }
                      

            // Vérification des coordonnées
            double cooX, cooY;
            if (!testCoord(textBoxX.Text, out cooX, -1000, 1000))
                PossibleDeChanger = false;
            if (!testCoord(textBoxY.Text, out cooY, -1000, 1000))
                PossibleDeChanger = false;

            Coordonnees coo = new Coordonnees(nom_position.Text, new Point((int)cooX, (int)cooY));
            string nomActiTmp = "";
            if (treeView1.SelectedNode == null && actiActuelle == null)
            {
                PossibleDeChanger = false;                
            }
            else if (treeView1.SelectedNode == null)
            {
                nomActiTmp = actiActuelle.Nom;
            }
            else
            {
                nomActiTmp = treeView1.SelectedNode.Text;
            }

            Activite tmpActi = new Activite(nomActiTmp, datesDebut, datesFin, coo, description.Text, jourSelec.ListActiviteJournee[0].ListSpationaute); //attention a l'assignation des Spationautes
            // Vérification des données
            if (!verifieDonnees(jourSelec.ListActiviteJournee, tmpActi))
                PossibleDeChanger = false;

            // Vérification le treeView
            if (!testTreeView())
                PossibleDeChanger = false;

            if (PossibleDeChanger)
            {
                jourSelec.ListActiviteJournee.Remove(actiActuelle);
                jourSelec.ListActiviteJournee.Add(tmpActi);
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

            double vraiCoordX = Math.Round(((((double)(eM.Location.X) / (double)(pictureBox1.Size.Width)) * 1095) - 700) / 5,2);
            double vraiCoordY = Math.Round(((((double)(eM.Location.Y) / (double)(pictureBox1.Size.Height)) * 2053) - 1000) / 5,2);

            textBoxX.Text = string.Format("{0}", vraiCoordX);
            textBoxY.Text = string.Format("{0}", vraiCoordY);
            graphics.DrawImage(patate, p);
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            jourSelec.ListActiviteJournee.Remove(actiActuelle);
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.journee = this.jourSelec;
            parent.rafraichirPage(jourSelec.NumJour);
        }

        private void textBoxXY_TextChanged(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            //int taille = 50;
            //Image patate = Image.FromFile("../../../patate.png");
            //patate = (Image)(new Bitmap(patate, new Size(taille, taille)));
            //int cooX = 0, cooY = 0;
            //int.TryParse(textBoxX.Text, out cooX);
            //int.TryParse(textBoxY.Text, out cooY);

            //int positionX = (int)((((((double)(cooX) * 5) + 700) / 1095) * pictureBox1.Size.Width));
            //int positionY = (int)((((((double)(cooY) * 5) + 1000) / 2053) * pictureBox1.Size.Height));

            //Point p = new Point(positionX - taille / 2, positionY - taille / 2);
            //if (graphics == null)
            //    graphics = pictureBox1.CreateGraphics();
            //graphics.DrawImage(patate, p);
        }
        #endregion

        private void niveau3_Paint(object sender, PaintEventArgs e)
        {

        }


        // Désactivation des éléments si la journée sélectionnée est passée
        private void desactiverJourPasses()
        {
            
            // RAJOUTER CONDITION pour insérer activité jours < jourSelec
            if (this.calendrierActuel.JourActuel > this.jourSelec.NumJour)
            {
                this.H_debut.Enabled = false;
                this.M_debut.Enabled = false;
                this.H_fin.Enabled = false;
                this.M_fin.Enabled = false;
                this.textBoxY.Enabled = false;
                this.textBoxX.Enabled = false;
                this.nom_position.Enabled = false;
                this.description.Enabled = false;
                this.btn_confirmer.Enabled = false;
                this.btn_annuler.Enabled = false;
                this.btn_suppr.Enabled = false;
            }
        }

        private void btn_retourJour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_debut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
