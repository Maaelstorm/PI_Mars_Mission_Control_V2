﻿using System;
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


#region Accesseurs & Propriétés

        public Form2 parent;
        public Journee jourSelec;
        public Activite actiActuelle;
        public System.Drawing.Graphics graphics; 
        private Calendrier calendrierActuel;

        private string _nomSpatio;

        private List<Spationaute> _listSpatio = new List<Spationaute>();

#endregion


#region Constructeur

        public Form3(Form2 p, Calendrier calendrier, Journee jourSelec, Activite actiActuelle, string nomSpatio)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            this.treeView1.ExpandAll();

            this.jour_actuel.Text = jourSelec.NumJour.ToString();
            this.jourSelec = jourSelec;
            this.actiActuelle = actiActuelle;

            this.calendrierActuel = calendrier;

            this._nomSpatio = nomSpatio;

            if (actiActuelle != null) // mets les caractéristiques d'une activité dans le cas d'un chargement d'activité
            {
                this.H_debut.SelectedItem = actiActuelle.HeureDebut.Heure.ToString();
                this.M_debut.SelectedItem = actiActuelle.HeureDebut.Minute.ToString();
                this.H_fin.SelectedItem = actiActuelle.HeureFin.Heure.ToString();
                this.M_fin.SelectedItem = actiActuelle.HeureFin.Minute.ToString();
                this.description.SelectedText = actiActuelle.Descritpion.ToString();
                this.labelActi.Text = actiActuelle.Nom;
                this.textBoxX.Text = string.Format("{0}", actiActuelle.Lieu.Position.X);
                this.textBoxY.Text = string.Format("{0}", actiActuelle.Lieu.Position.Y);
                this._listSpatio = this.calendrierActuel.ListSpationaute;
            }
            else
            {
                this.labelActi.Text = "Aucun type d'activité sélectionné";
                btn_suppr.Enabled = false; // laisse les champs vide pour une création d'activité 

                for (int i = 0; i < this.calendrierActuel.ListSpationaute.Count; i++)
                {
                    if (this.calendrierActuel.ListSpationaute.ElementAt(i).Nom.ToString() == this._nomSpatio)
                    {
                        this._listSpatio.Add(this.calendrierActuel.ListSpationaute.ElementAt(i));
                    }
                }
            }
           
            parent = p;

            graphics = pictureBox1.CreateGraphics();

            changerCouleurJours();
            desactiverJourPasses();
        }

#endregion


#region Méthode de vérification

        private bool verifieDonnees(List<Activite> listActi, Activite tmpActi) // vérifie que l'emplacement horaire est libre pour la création de l'activité
        {
            if (tmpActi.HeureDebut == null || tmpActi.HeureFin == null)
            {
                return false;
            }
            else if ((tmpActi.HeureDebut.Heure * 60 + tmpActi.HeureDebut.Minute) > (tmpActi.HeureFin.Heure * 60 + tmpActi.HeureFin.Minute))
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
                        if (!((tmpActi.HeureDebut.Heure * 60 + tmpActi.HeureDebut.Minute) <= (item.HeureFin.Heure * 60 + item.HeureFin.Minute)))
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


        private bool testCoord(string coord, out double valeur, int coordMin, int coordMax) // vérifie que les coordonées rentrées sont cohérentes
        {
            bool res = double.TryParse(coord, out valeur);
            if (coordMin > valeur || coordMax < valeur)
                res = false;
            return res;
        }


        private bool testTreeView() // annule la sélection automatique d'un noeud dans le treeView
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

            // vérifie qu'on renseigne bien des horaires
            if (H_debut.Text == "" || M_debut.Text == "" || H_fin.Text == "" || M_fin.Text == "")
            {
                PossibleDeChanger = false;
            }
            else
            {
                datesDebut = new Dates(jourSelec.NumJour, int.Parse(H_debut.Text), int.Parse(M_debut.Text));
                datesFin = new Dates(jourSelec.NumJour, int.Parse(H_fin.Text), int.Parse(M_fin.Text));
            }

            // vérifie qu'on renseigne bien des coordonnées
            double cooX, cooY;
            if (!testCoord(textBoxX.Text, out cooX, -1000, 1000))
                PossibleDeChanger = false;
            if (!testCoord(textBoxY.Text, out cooY, -1000, 1000))
                PossibleDeChanger = false;

            Coordonnees coo = new Coordonnees(nom_position.Text, new Point((int)cooX, (int)cooY));
            string nomActiTmp = "";
            if (treeView1.SelectedNode == null && actiActuelle == null) // vérifie qu'on sélectionne bien un type d'activité
            {
                PossibleDeChanger = false;
            }
            else if (treeView1.SelectedNode == null) // par défaut, mais le type de l'activité sélectionné si c'est un chargement d'activité
            {
                nomActiTmp = actiActuelle.Nom;
            }
            else
            {
                nomActiTmp = treeView1.SelectedNode.Text; // autrement, met ls noeud sélectionné par l'utilisateur
            }            

            Activite tmpActi = new Activite(nomActiTmp, datesDebut, datesFin, coo, description.Text, this._listSpatio); //attention a l'assignation des Spationautes
            // Vérification des données
            if (!verifieDonnees(jourSelec.ListActiviteJournee, tmpActi))
                PossibleDeChanger = false;

            // Vérification du treeView
            if (!testTreeView())
                PossibleDeChanger = false;

            if (PossibleDeChanger) // ajoute ou modifie l'activité
            {
                jourSelec.ListActiviteJournee.Remove(actiActuelle);
                jourSelec.ListActiviteJournee.Add(tmpActi);
                actiActuelle = tmpActi;
                this.Close();
            }
            else // si un des critères n'est pas vérifié, un pop-up annonce la modification ou création impossible et renvoie au form de modification
            {
                PopUp_ModifImpossible popup = new PopUp_ModifImpossible();
                DialogResult dialogresult = popup.ShowDialog();
                popup.Dispose();
            }
        }


        private void H_debut_SelectedIndexChanged(object sender, EventArgs e) // enlève la valeur "50" des minutes si on sélectionne l'heure "24"
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


        private void H_fin_SelectedIndexChanged(object sender, EventArgs e) // enlève la valeur "50" des minutes si on sélectionne l'heure "24"
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


        private void pictureBox1_Click(object sender, EventArgs e) // Gestion de la carte
        {
            pictureBox1.Refresh();
            MouseEventArgs eM = (MouseEventArgs)e; // événement lié à la souris
            int taille = 50;
            Image robot = Image.FromFile("../../../robot.png"); // charge l'image de robot qui apparaitra sur la carte au clic
            robot = (Image)(new Bitmap(robot, new Size(taille, taille))); 
            Point p = new Point(eM.Location.X - taille / 2, eM.Location.Y - taille / 2); // récupère la coordonnée du clic de la souris sur l'image

            double vraiCoordX = Math.Round(((((double)(eM.Location.X) / (double)(pictureBox1.Size.Width)) * 1095) - 700) / 5, 2); // convertion des pixels en mètres
            double vraiCoordY = Math.Round(((((double)(eM.Location.Y) / (double)(pictureBox1.Size.Height)) * 2053) - 1000) / 5, 2); // convertion des pixels en mètres

            textBoxX.Text = string.Format("{0}", vraiCoordX); // affiche les coordonnées en mètres calculées dans les textBox
            textBoxY.Text = string.Format("{0}", vraiCoordY);
            graphics.DrawImage(robot, p); // affiche le robot au point cliqué
        }


        private void btn_annuler_Click(object sender, EventArgs e) // Ferme le Form sans modification
        {
            this.Close();
        }


        private void btn_suppr_Click(object sender, EventArgs e) // Retire l'activité de la liste d'activités
        {
            for (int i = 0; i < jourSelec.ListActiviteJournee.Count; i++)
			{
			    for (int j = 0; j < this.actiActuelle.ListSpationaute.Count; j++)
                {
                    if (this.actiActuelle.ListSpationaute.ElementAt(j).Nom == this._nomSpatio)
                    {
                        this.actiActuelle.ListSpationaute.RemoveAt(j);
                    }
                }
			}

            this.parent.rafraichirPage(this.jourSelec.NumJour);
            
            this.Close();
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.journee = this.jourSelec;
            parent.rafraichirPage(jourSelec.NumJour);
        }

#endregion
        

        private void desactiverJourPasses() // Désactivation des éléments si la journée sélectionnée est passée
        {
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


        private void changerCouleurJours()
        {
            // Label Jour sélectionné
            if (int.Parse(jour_actuel.Text) < calendrierActuel.JourActuel)
                panel2.BackColor = Color.LightGray;
            else if (int.Parse(jour_actuel.Text) == calendrierActuel.JourActuel)
                panel2.BackColor = Color.LightBlue;
            else
                panel2.BackColor = Color.LimeGreen;
        }


        private void btn_retourJour_Click(object sender, EventArgs e) // retourne à la journée sans modification
        {
            this.Close();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.labelActi.Text = this.treeView1.SelectedNode.Text;                
        }

    }
}
