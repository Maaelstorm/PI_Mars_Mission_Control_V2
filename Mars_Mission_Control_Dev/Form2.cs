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
        private Journee _jourSelec;
        private Calendrier _calendrierActuel;
        private int _taille10minPixel;               
        
        //private List<Activite> _listActi = new List<Activite>(); // liste des activités
        
        private List<int> _listTailles = new List<int>(); // taille en pixel d'une activité
        private List<int> _listEcart = new List<int>(); // ecart entre 2 activités
        private List<Button> _listBtnActi = new List<Button>();

        private List<Panel> _listPanelActivites;

        public Form2(Calendrier calendrier, Journee jour)
        {
			this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            this._listPanelActivites = new List<Panel>(calendrier.ListSpationaute.Count);
            for (int i = 0; i < _listPanelActivites.Count; i++)
            {
                List<TabPage> _listTabPage = new List<TabPage>();
               
                //_listTabPage = this.tabControl1.TabPages.GetEnumerator();
               
                //this._listPanelActivites.Add();
            }

            this.tabPage1.Text = calendrier.ListSpationaute.ElementAt(0).Nom;
            this.tabPage2.Text = calendrier.ListSpationaute.ElementAt(1).Nom;
            this.tabPage3.Text = calendrier.ListSpationaute.ElementAt(2).Nom;

            _jourSelec = jour;
            _calendrierActuel = calendrier;
            this.tagjourSelec.Text = jour.NumJour.ToString();
            this.tagjourSelec2.Text = jour.NumJour.ToString();
            _taille10minPixel = 5; // 10 Minutes = 5 pixel
            this.tb_compteRendu.Text = _jourSelec.CompteRendu;

            afficheBoutons(1);

            // On désactive les contrôles si la journée est passée
            desactiverJourPasses();
        }


#region Méthodes

        public Journee journee
        {
            get { return _jourSelec; }
            set { _jourSelec = value; }
        }

        private void retourCalendrier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void rafraichirPage(int jour)
        {
            _jourSelec = _calendrierActuel.ListJournees.ElementAt(jour - 1);

            miseAJourJour(_jourSelec.NumJour);
            tb_compteRendu.Text = _jourSelec.CompteRendu;
            
            // On affiche la 1ère tab lorsqu'on arrive sur le niveau 2
            afficheBoutons(1);

            desactiverJourPasses();
        }

        private void miseAJourJour(int jour)
        {
            this.tagjourSelec.Text = this.tagjourSelec2.Text = jour.ToString();
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {           
            if (_jourSelec.NumJour > 1)
                rafraichirPage(_jourSelec.NumJour - 1);
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            if (_jourSelec.NumJour < _calendrierActuel.ListJournees.Count)
                rafraichirPage(_jourSelec.NumJour + 1);
        }

        private void inserer_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, this._calendrierActuel, this._jourSelec, null);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }



        // Cette fonction affichera les bonnes activités dans chaque TAB du panel (celle auxquelles le spationaute participe)
        private void switchTab(object sender, EventArgs e)
        {
            // On passe en paramètre l'index de la Tab sélectionnée
            afficheBoutons( ((TabControl)sender).SelectedIndex );
        }

        

        private void afficheBoutons(int tabIndex)
        {
            // TROUVER MOYEN DE G2RER les panelActivity
                       

            //this._listPanelActivites.ElementAt(tabIndex - 1).Controls.Clear();

            this.panelActivites1.Controls.Clear();

            tailleChaqueCreneaux();
            
            int posX = 10, posY = 10;

            for (int i = 0; i < _jourSelec.ListActiviteJournee.Count; i++)
            {
                Button BtnActi = new Button();
                BtnActi.Size = new Size(200, _listTailles[i]);
                BtnActi.Text = (_jourSelec.ListActiviteJournee[i].Nom);
                BtnActi.Location = (new Point(posX, posY + (_jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + _jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel));
                BtnActi.Tag = _jourSelec.ListActiviteJournee[i];
                BtnActi.Name = _jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

                Label label = new Label();
                label.Name = "labelActivites";
                label.Location = new Point(posX + 210, posY + (_jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + _jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel);
                label.Text = _jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

                this.panelActivites1.Controls.Add(BtnActi);
                this.panelActivites1.Controls.Add(label);
                

                BtnActi.Click += activite_Click;
                BtnActi.MouseHover += BtnActi_MouseHover;
                BtnActi.MouseLeave += BtnActi_Leave;
                _listBtnActi.Add(BtnActi);
            }

            //return _listBtnActi;
        }
               
        // Ajoute La liste des tailles des activités pour chaque créneau
        private void tailleChaqueCreneaux()
        {
            // On commence par réinitialiser les listes
            _listEcart.Clear();
            _listTailles.Clear();

            // Pour chaque activité de la journée 
            foreach (Activite i in _jourSelec.ListActiviteJournee)
            {
                // On ajoute la taille de chaque activité à une liste d'entiers : _listTailles
                _listTailles.Add(tailleActivite(i));
            }

            // écart entre Heure 0 et première activité
            _listEcart.Add(((_jourSelec.ListActiviteJournee[0].HeureDebut.Heure * 60 + _jourSelec.ListActiviteJournee[0].HeureDebut.Minute) - 0) / 10 * _taille10minPixel); 

            for (int j = 0; j < _jourSelec.ListActiviteJournee.Count() - 1; j++)
            {
                // écart entre 2 activités
                _listEcart.Add(((_jourSelec.ListActiviteJournee[j + 1].HeureDebut.Heure * 60 + _jourSelec.ListActiviteJournee[j + 1].HeureDebut.Minute) - (_jourSelec.ListActiviteJournee[j].HeureFin.Heure * 60 + _jourSelec.ListActiviteJournee[j].HeureFin.Minute)) / 10 * _taille10minPixel); 
            }

            // écart entre dernière activité et 24h40
            _listEcart.Add(((24 * 60 + 40 - (_jourSelec.ListActiviteJournee[_jourSelec.ListActiviteJournee.Count - 1].HeureFin.Heure * 60 + _jourSelec.ListActiviteJournee[_jourSelec.ListActiviteJournee.Count - 1].HeureFin.Minute))) / 10 * _taille10minPixel); 
        }
        
        // Cette fonction renvoie la taille d'une activité en pixel (nombre entier)
        private int tailleActivite(Activite Activitee)
        {
            return ((Activitee.HeureFin.Heure - Activitee.HeureDebut.Heure) * 60 + (Activitee.HeureFin.Minute - Activitee.HeureDebut.Minute)) / 10 * _taille10minPixel;
        }
        

        private void tb_Description_TextChanged(object sender, EventArgs e)
        {

        }


        // On modifie le compte rendu de l'objet jour à partir de la saisie utilisateur
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
			_jourSelec.CompteRendu = tb_compteRendu.Text;
        }

        private void activite_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, this._calendrierActuel, this._jourSelec, (Activite)((Button)sender).Tag);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }

        private void BtnActi_Leave(object sender, EventArgs e)
        {
            tb_Description.Text = "Survolez une activité pour voir son descriptif.";
            label_nom_acti.Text = "Activité";
        }

        private void BtnActi_MouseHover(object sender, EventArgs e)
        {
			label_nom_acti.Text = ((Button)sender).Text.ToString();
			
			Activite act = (Activite)((Button)sender).Tag;
			tb_Description.Text = act.Descritpion;
        }


#endregion

        private void panelActivites_Paint(object sender, PaintEventArgs e)
        {

        }




        

        // Désactivation des éléments si la journée sélectionnée est passée
        private void desactiverJourPasses()
        {
            if (this._calendrierActuel.JourActuel > this._jourSelec.NumJour)
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

        private void panelActivites2_Paint(object sender, PaintEventArgs e)
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
