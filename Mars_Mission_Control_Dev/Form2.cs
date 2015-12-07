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

        public Form2(Calendrier calendrier, Journee jour, Journee jourActuel)
        {
            InitializeComponent();
            jourActuel.NumJour = calendrier.NumJour;
            jourSelec = jour;
            calendrierActuel = calendrier;
            this.tagjourSelec.Text = jour.NumJour.ToString();
            this.tagjourSelec2.Text = jour.NumJour.ToString();
            _taille10minPixel = 5; // 10 Minutes = 5 pixel
            this.richTextBox2.Text = jourSelec.CompteRendu;

            afficheBoutons();
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
            jourSelec = calendrierActuel.ListJournees.ElementAt(jour);

            miseAJourJour(jourSelec.NumJour);
            richTextBox2.Text = jourSelec.CompteRendu;
            afficheBoutons();
        }

        private void miseAJourJour(int jour)
        {
            this.tagjourSelec.Text = this.tagjourSelec2.Text = jour.ToString();
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            if (jourSelec.NumJour != 0)
                rafraichirPage(jourSelec.NumJour - 1);
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            if (jourSelec.NumJour != 499)
                rafraichirPage(jourSelec.NumJour + 1);
        }

        private void inserer_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, this.calendrierActuel, this.jourSelec, null);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

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

            if (jourSelec < )
            {
                
            }

            return ListBtnActi;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void activite_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, this.calendrierActuel, this.jourSelec, (Activite)((Button)sender).Tag);
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }

        private void BtnActi_Leave(object sender, EventArgs e)
        {
            richTextBox1.Text = "Survolez une activité pour voir son descriptif.";
            label_nom_acti.Text = "Activité";
        }

        private void BtnActi_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = ((Button)sender).Tag.ToString();
            label_nom_acti.Text = ((Button)sender).Text.ToString();
        }

        #endregion

    }
}
