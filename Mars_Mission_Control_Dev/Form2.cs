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
    public partial class Form2 : Form
    {
        private Journee jourSelec;
        public Journee journee
        {
            get { return jourSelec; }
            set { jourSelec = value; }
        }

        private Calendrier calendrierActuel;
        private int _taille10minPixel;
        private List<Activite> _listActi = new List<Activite>(); // liste des activités
        private List<int> _listTailles = new List<int>(); // taille en pixel d'une activité
        private List<int> _listEcart = new List<int>(); // écart entre 2 activités
        private List<Button> _listBtnActi = new List<Button>(); // liste des boutons des activités

        private List<Panel> _listPanelActivites; // Liste de panel (3 tab correspondants aux 3 spationautes)

        public Form2(Calendrier calendrier, Journee jour)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
                        
            this._listPanelActivites = new List<Panel>(calendrier.ListSpationaute.Count);
            // Ajout des 3 tab à la liste des panels
            this._listPanelActivites.Add(panelActivites1);
            this._listPanelActivites.Add(panelActivites2);
            this._listPanelActivites.Add(panelActivites3);
            
            jourSelec = jour;
            calendrierActuel = calendrier;
            this.tagjourSelec.Text = jour.NumJour.ToString();
            this.tagjourSelec2.Text = jour.NumJour.ToString();

            _taille10minPixel = 5; // 10 Minutes = 5 pixel
            this.tb_compteRendu.Text = jourSelec.CompteRendu;

            afficheBoutons(0);

            changerCouleurJours();

            // On désactive les contrôles si la journée est passée
            desactiverJourPasses();
        }


#region Méthodes

        private void switchTab(object sender, EventArgs e)
        {
            // On passe en paramètre l'index de la Tab sélectionnée
            int index = ((TabControl)sender).SelectedIndex;
            afficheBoutons(index);
        }


#region NOUVEAU CODE AFFICHAGE BOUTONS
        
        // FONCTIONNE A PRIORI MAIS PAS LA PARTIE tailleChaqueCreneaux();
        // SI SUPPRESSION d'UNE ACTI POUR UNE JOURNEE POUR UN SPATION
        // = SUPPRESSION DE CETTE ACTI POUR CE SPATIO POUR TOUTES LES JOURNEES
        //private void afficheBoutons(int index)
        //{
        //    this._listBtnActi.Clear();
        //    this._listPanel.ElementAt(index).Controls.Clear();

        //    tailleChaqueCreneaux();
        //    int posX = 10, posY = 10;

        //    // créer les boutons des activités avec les bonnes tailles, bon écart (et donc emplacement), bon nom selon les activités
        //    for (int i = 0; i < jourSelec.ListActiviteJournee.Count; i++)
        //    {
        //        List<Spationaute> listSpatio = this.jourSelec.ListActiviteJournee.ElementAt(i).ListSpationaute;

        //        for (int j = 0; j < listSpatio.Count; j++)
        //        {
        //            // Si le nom du spationaute de la tab sélectionnée est dans la liste de l'activité alors on créer les boutons
        //            if (listSpatio.ElementAt(j).Nom == this.tabSpatio.SelectedTab.Text)
        //            {
        //                Button BtnActi = new Button();
        //                BtnActi.Size = new Size(200, _listTailles[i]);
        //                BtnActi.Text = (jourSelec.ListActiviteJournee[i].Nom);
        //                BtnActi.Location = (new Point(posX, posY + (jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel));
        //                BtnActi.Tag = jourSelec.ListActiviteJournee[i];
        //                BtnActi.Name = jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

        //                Label label = new Label();
        //                label.Name = "labelActivites";
        //                label.Location = new Point(posX + 210, posY + (jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel);
        //                label.Text = jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

        //                this._listPanel.ElementAt(index).Controls.Add(BtnActi);
        //                this._listPanel.ElementAt(index).Controls.Add(label);

        //                BtnActi.Click += activite_Click; // événement lié au clic sur un bouton
        //                BtnActi.MouseHover += BtnActi_MouseHover; // événement lié au passage de la souris sur le bouton
        //                BtnActi.MouseLeave += BtnActi_Leave; // événement lié au fait que la souris n'est plus sur le bouton
        //                _listBtnActi.Add(BtnActi);
        //            }
        //        }


        //    }
        //}

        //private int tailleActivite(Activite Activitee)
        //{
        //    // donne la taille en pixel que devra avoir le bouton, en hauteur, en fonction de la durée de l'activité, par tranche de 10 minutes
        //    return ((Activitee.HeureFin.Heure - Activitee.HeureDebut.Heure) * 60 + (Activitee.HeureFin.Minute - Activitee.HeureDebut.Minute)) / 10 * _taille10minPixel;
        //}

        //// A CORRIGER 
        //private void tailleChaqueCreneaux()
        //{
        //    //_listEcart.Clear();
        //    //_listTailles.Clear();

        //    //for (int i = 0; i < jourSelec.ListActiviteJournee.Count; i++)
        //    //{
        //    //    List<Spationaute> listSpatio = this.jourSelec.ListActiviteJournee.ElementAt(i).ListSpationaute;

        //    //    for (int j = 0; j < listSpatio.Count; j++)
        //    //    {
        //    //        if (listSpatio.ElementAt(j).Nom == this.tabSpatio.SelectedTab.Text)
        //    //        {
        //    //            _listTailles.Add(tailleActivite(jourSelec.ListActiviteJournee.ElementAt(i))); // ajoute les tailles en hauteur que devront avoir les boutons

        //    //            // calcule les écarts qu'il devra y avoir entre deux activités, sur le même principe que la taille d'une activité
        //    //            _listEcart.Add(((jourSelec.ListActiviteJournee[0].HeureDebut.Heure * 60 + jourSelec.ListActiviteJournee[0].HeureDebut.Minute) - 0) / 10 * _taille10minPixel); // écart entre Heure 0 et première activité
        //    //        }
        //    //    }
        //    //}




        //    //for (int i = 0; i < jourSelec.ListActiviteJournee.Count - 1; i++)
        //    //{
        //    //    List<Spationaute> listSpatio = this.jourSelec.ListActiviteJournee.ElementAt(i).ListSpationaute;

        //    //    for (int j = 0; j < listSpatio.Count; j++)
        //    //    {
        //    //        if (listSpatio.ElementAt(j).Nom == this.tabSpatio.SelectedTab.Text)
        //    //        {
        //    //            // puis on ajoute les écarts à la liste
        //    //            _listEcart.Add(((jourSelec.ListActiviteJournee[j + 1].HeureDebut.Heure * 60 + jourSelec.ListActiviteJournee[j + 1].HeureDebut.Minute) - (jourSelec.ListActiviteJournee[j].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[j].HeureFin.Minute)) / 10 * _taille10minPixel); // écart entre 2 activités

        //    //            _listEcart.Add(((24 * 60 + 40 - (jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Minute))) / 10 * _taille10minPixel); // écart entre dernière activité et 24h40
        //    //        }
        //    //    }
        //    //}            




        //    // - ANCIEN CODE 

        //    _listEcart.Clear();
        //    _listTailles.Clear();

        //    _listEcart.Add(((24 * 60 + 40 - (jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Minute))) / 10 * _taille10minPixel); // écart entre dernière activité et 24h40
        //}

#endregion



#region ANCIEN CODE AFFICHAGE BOUTONS
        private int tailleActivite(Activite Activitee)
        {
            // donne la taille en pixel que devra avoir le bouton, en hauteur, en fonction de la durée de l'activité, par tranche de 10 minutes
            // sachant que 10 minutes = 5 pixels
            return ((Activitee.HeureFin.Heure - Activitee.HeureDebut.Heure) * 60 + (Activitee.HeureFin.Minute - Activitee.HeureDebut.Minute)) / 10 * _taille10minPixel;
        }

        private void tailleChaqueCreneaux()
        {
            _listEcart.Clear();
            _listTailles.Clear();

            foreach (Activite i in jourSelec.ListActiviteJournee)
            {
                _listTailles.Add(tailleActivite(i)); // ajoute les tailles en hauteur que devront avoir les boutons
            }

            // calcule les écarts qu'il devra y avoir entre deux activités, sur le même principe que la taille d'une activité
            _listEcart.Add(((jourSelec.ListActiviteJournee[0].HeureDebut.Heure * 60 + jourSelec.ListActiviteJournee[0].HeureDebut.Minute) - 0) / 10 * _taille10minPixel); // écart entre Heure 0 et première activité

            // puis on ajoute les écarts à la liste
            for (int j = 0; j < jourSelec.ListActiviteJournee.Count() - 1; j++)
            {
                _listEcart.Add(((jourSelec.ListActiviteJournee[j + 1].HeureDebut.Heure * 60 + jourSelec.ListActiviteJournee[j + 1].HeureDebut.Minute) - (jourSelec.ListActiviteJournee[j].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[j].HeureFin.Minute)) / 10 * _taille10minPixel); // écart entre 2 activités
            }

            _listEcart.Add(((24 * 60 + 40 - (jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Minute))) / 10 * _taille10minPixel); // écart entre dernière activité et 24h40
        }

        private List<Button> afficheBoutons(int index)
        {
            this._listBtnActi.Clear();

            this.panelActivites1.Controls.Clear();
            tailleChaqueCreneaux();
            int posX = 10, posY = 10;

            // créer les boutons des activités avec les bonnes tailles, bon écart (et donc emplacement), bon nom selon les activités
            for (int i = 0; i < jourSelec.ListActiviteJournee.Count; i++)
            {
                Button BtnActi = new Button();
                BtnActi.Size = new Size(200, _listTailles[i]);
                BtnActi.Text = (jourSelec.ListActiviteJournee[i].Nom);
                BtnActi.Location = (new Point(posX, posY + (jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel));
                BtnActi.Tag = jourSelec.ListActiviteJournee[i];
                BtnActi.Name = jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

                Label label = new Label();
                label.Name = "labelActivites";
                label.Location = new Point(posX + 210, posY + (jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel);
                label.Text = jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

                this.panelActivites1.Controls.Add(BtnActi);
                this.panelActivites1.Controls.Add(label);

                BtnActi.Click += activite_Click; // événement lié au clic sur un bouton
                BtnActi.MouseHover += BtnActi_MouseHover; // événement lié au passage de la souris sur le bouton
                BtnActi.MouseLeave += BtnActi_Leave; // événement lié au fait que la souris n'est plus sur le bouton
                _listBtnActi.Add(BtnActi);
            }

            return _listBtnActi;
        }
#endregion


        //private void retourCalendrier_Click(object sender, EventArgs e)
        //{
        //    miseAJourJour(jourSelec.NumJour);
        //    // on met à jour le compte rendu du jour sur lequel on est
        //    tb_compteRendu.Text = jourSelec.CompteRendu;

        //    afficheBoutons(0);

        //    changerCouleurJours();
        //    desactiverJourPasses();
        //}

        // ANCIENNE METHODE
        private void retourCalendrier_Click(object sender, EventArgs e)
        {
            // on retourne sur le calendrier → on ferme le form 2
            this.Close();
        }

        public void rafraichirPage(int jour)
        {
            // on met à jour le jour sur lequel on est
            jourSelec = calendrierActuel.ListJournees.ElementAt(jour - 1);

            miseAJourJour(jourSelec.NumJour);
            // on met à jour le compte rendu du jour sur lequel on est
            tb_compteRendu.Text = jourSelec.CompteRendu;
            
            afficheBoutons(0);

            changerCouleurJours();
            desactiverJourPasses();
        }

        private void miseAJourJour(int jour)
        {
            // on met à jour le numéro du jour sur lequel on est
            this.tagjourSelec.Text = this.tagjourSelec2.Text = jour.ToString();
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            if (jourSelec.NumJour > 1)
                rafraichirPage(jourSelec.NumJour - 1);
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            if (jourSelec.NumJour < calendrierActuel.ListJournees.Count)
                rafraichirPage(jourSelec.NumJour + 1);
        }

       

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            jourSelec.CompteRendu = tb_compteRendu.Text; // affichage du compte rendu de la journée
        }

        private void activite_Click(object sender, EventArgs e) // clic sur activité → ouverture du form3
        {
            Form3 f3 = new Form3(this, this.calendrierActuel, this.jourSelec, (Activite)((Button)sender).Tag, this.tabSpatio.SelectedTab.Text);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }


        // Au passage de la souris sur le bouton, on affiche les informations liées à l'activité
        // permet de contrer les problèmes de lecture en cas d'activité courte où le texte n'est 
        // pas lisible sur le bouton
        private void BtnActi_MouseHover(object sender, EventArgs e) 
        {
            label_nom_acti.Text = ((Button)sender).Text.ToString();

            Activite act = (Activite)((Button)sender).Tag;
            tb_Description.Text = act.Descritpion;
        }

        // Remet un texte par défaut quand la souris quitte le bouton
        private void BtnActi_Leave(object sender, EventArgs e) 
        {
            tb_Description.Text = "Survolez une activité pour voir son descriptif.";
            label_nom_acti.Text = "Activité";
        }


        private void inserer_Click(object sender, EventArgs e) // création d'activité → form3
        {
            Form3 f3 = new Form3(this, this.calendrierActuel, this.jourSelec, null, this.tabSpatio.SelectedTab.Text);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }


        // Désactivation des éléments si la journée sélectionnée est passée
        private void desactiverJourPasses()
        {
            if (this.calendrierActuel.JourActuel > this.jourSelec.NumJour)
            {
                this.btn_insert.Enabled = false;
                this.tb_compteRendu.Enabled = false;
            }
            else
            {
                this.btn_insert.Enabled = true;
                this.tb_compteRendu.Enabled = true;
            }
        }


        private void changerCouleurJours()
        {
            // Bouton jour précédent
            if (int.Parse(tagjourSelec.Text) - 1 < calendrierActuel.JourActuel)
                btn_prevDay.BackColor = Color.LightGray;
            else if (int.Parse(tagjourSelec.Text) - 1 == calendrierActuel.JourActuel)
                btn_prevDay.BackColor = Color.LightBlue;
            else
                btn_prevDay.BackColor = Color.LimeGreen;

            // Label Jour Actuel
            if (int.Parse(tagjourSelec.Text) < calendrierActuel.JourActuel)
                panel2.BackColor = Color.LightGray;
            else if (int.Parse(tagjourSelec.Text) == calendrierActuel.JourActuel)
                panel2.BackColor = Color.LightBlue;
            else
                panel2.BackColor = Color.LimeGreen;

            // Bouton jour suivant
            if (int.Parse(tagjourSelec.Text) + 1 < calendrierActuel.JourActuel)
                btn_nextDay.BackColor = Color.LightGray;
            else if (int.Parse(tagjourSelec.Text) + 1 == calendrierActuel.JourActuel)
                btn_nextDay.BackColor = Color.LightBlue;
            else
                btn_nextDay.BackColor = Color.LimeGreen;
        }


        #endregion


        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        #region en test
        
        // FONCTION QUI PEUT SERVIR A AFFICHER DES ICONES SUR UN BOUTTON

        //private void SetMyButtonIcon(Button BtnActi)
        //{
        //    // Assign an image to the button.
        //    BtnActi.Image = Image.FromFile("C:\\Graphics\\My.ico");
        //    // Align the image and text on the button.
        //    BtnActi.ImageAlign = ContentAlignment.MiddleRight;
        //    BtnActi.TextAlign = ContentAlignment.MiddleLeft;
        //}

        #endregion

    }
}
