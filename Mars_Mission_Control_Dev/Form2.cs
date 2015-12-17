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
        private Calendrier calendrierActuel;
        private int _taille10minPixel;
        private List<Activite> listActi = new List<Activite>(); // liste des activités
        List<int> listTailles = new List<int>(); // taille en pixel d'une activité
        List<int> listEcart = new List<int>(); // ecart entre 2 activités
        List<Button> ListBtnActi = new List<Button>();

        public Form2(Calendrier calendrier, Journee jour)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            jourSelec = jour;
            calendrierActuel = calendrier;
            this.tagjourSelec.Text = jour.NumJour.ToString();
            this.tagjourSelec2.Text = jour.NumJour.ToString();
            _taille10minPixel = 5; // 10 Minutes = 5 pixel
            this.tb_compteRendu.Text = jourSelec.CompteRendu;

            afficheBoutons();

            // On désactive les contrôles si la journée est passée
            desactiverJourPasses();
        }

        #region Méthodes

        public Journee journee
        {
            get { return jourSelec; }
            set { jourSelec = value; }
        }

        private void retourCalendrier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void rafraichirPage(int jour)
        {
            jourSelec = calendrierActuel.ListJournees.ElementAt(jour - 1);

            miseAJourJour(jourSelec.NumJour);
            tb_compteRendu.Text = jourSelec.CompteRendu;
            afficheBoutons();

            desactiverJourPasses();
        }

        private void miseAJourJour(int jour)
        {
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

        private int tailleActivite(Activite Activitee)
        {
            return ((Activitee.HeureFin.Heure - Activitee.HeureDebut.Heure) * 60 + (Activitee.HeureFin.Minute - Activitee.HeureDebut.Minute)) / 10 * _taille10minPixel;
        }

        private void tailleChaqueCreneaux()
        {
            listEcart.Clear();
            listTailles.Clear();

            foreach (Activite i in jourSelec.ListActiviteJournee)
            {
                listTailles.Add(tailleActivite(i));
            }

            listEcart.Add(((jourSelec.ListActiviteJournee[0].HeureDebut.Heure * 60 + jourSelec.ListActiviteJournee[0].HeureDebut.Minute) - 0) / 10 * _taille10minPixel); // écart entre Heure 0 et première activité

            for (int j = 0; j < jourSelec.ListActiviteJournee.Count() - 1; j++)
            {
                listEcart.Add(((jourSelec.ListActiviteJournee[j + 1].HeureDebut.Heure * 60 + jourSelec.ListActiviteJournee[j + 1].HeureDebut.Minute) - (jourSelec.ListActiviteJournee[j].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[j].HeureFin.Minute)) / 10 * _taille10minPixel); // écart entre 2 activités
            }

            listEcart.Add(((24 * 60 + 40 - (jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Heure * 60 + jourSelec.ListActiviteJournee[jourSelec.ListActiviteJournee.Count - 1].HeureFin.Minute))) / 10 * _taille10minPixel); // écart entre dernière activité et 24h40
        }

        private List<Button> afficheBoutons()
        {
            this.panelActivites.Controls.Clear();
            tailleChaqueCreneaux();
            int posX = 10, posY = 10;

            for (int i = 0; i < jourSelec.ListActiviteJournee.Count; i++)
            {
                Button BtnActi = new Button();
                BtnActi.Size = new Size(200, listTailles[i]);
                BtnActi.Text = (jourSelec.ListActiviteJournee[i].Nom);
                BtnActi.Location = (new Point(posX, posY + (jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel));
                BtnActi.Tag = jourSelec.ListActiviteJournee[i];
                BtnActi.Name = jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

                Label label = new Label();
                label.Name = "labelActivites";
                label.Location = new Point(posX + 210, posY + (jourSelec.ListActiviteJournee[i].HeureDebut.Heure * 6 + jourSelec.ListActiviteJournee[i].HeureDebut.Minute / 10) * _taille10minPixel);
                label.Text = jourSelec.ListActiviteJournee[i].HeureDebut.ToString();

                this.panelActivites.Controls.Add(BtnActi);
                this.panelActivites.Controls.Add(label);

                BtnActi.Click += activite_Click;
                BtnActi.MouseHover += BtnActi_MouseHover;
                BtnActi.MouseLeave += BtnActi_Leave;
                ListBtnActi.Add(BtnActi);
            }

            return ListBtnActi;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            jourSelec.CompteRendu = tb_compteRendu.Text;
        }

        private void activite_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, this.calendrierActuel, this.jourSelec, (Activite)((Button)sender).Tag);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }

        private void BtnActi_MouseHover(object sender, EventArgs e)
        {
            label_nom_acti.Text = ((Button)sender).Text.ToString();

            Activite act = (Activite)((Button)sender).Tag;
            tb_Description.Text = act.Descritpion;
        }

        private void BtnActi_Leave(object sender, EventArgs e)
        {
            tb_Description.Text = "Survolez une activité pour voir son descriptif.";
            label_nom_acti.Text = "Activité";
        }


        private void inserer_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, this.calendrierActuel, this.jourSelec, null);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }


        #endregion


        #region en test

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
