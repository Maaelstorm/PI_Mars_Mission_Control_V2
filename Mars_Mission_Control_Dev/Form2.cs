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
    public partial class Form2 : Form
    {
        private Journee jourActuel;
        private Calendrier calendrierActuel;
        private int _taille10minPixel;
        private List<Activite> listActi = new List<Activite>(); // liste des activités
        List<int> listTailles = new List<int>(); // taille en pixel d'une activité
        List<int> listEcart = new List<int>(); // ecart entre 2 activités
        

        public Form2(Calendrier calendrier,Journee jour)
        {
            InitializeComponent();
            jourActuel = jour;
            calendrierActuel = calendrier;
            this.tagJourActuel.Text = jour.NumJour.ToString();
            this.tagJourActuel2.Text = jour.NumJour.ToString();            
            _taille10minPixel = 5; // 10 minutes = 5 pixel
            this.richTextBox2.Text = jourActuel.CompteRendu;

            afficheBoutons();
        }

#region Méthodes

        public Journee journee { get; set; }

        private void retourCalendrier_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void rafraichirPage(int jour)
        {               
            jourActuel = calendrierActuel.ListJournees.ElementAt(jour);       

            miseAJourJour(jourActuel.NumJour);
            richTextBox2.Text = jourActuel.CompteRendu;
            afficheBoutons();
        }

        private void miseAJourJour(int jour)
        {
            this.tagJourActuel.Text = this.tagJourActuel2.Text = jour.ToString();
        }

        private void jourPrecedent_Click(object sender, EventArgs e)
        {
            if (jourActuel.NumJour != 0)             
                rafraichirPage(jourActuel.NumJour - 1);
        }

        private void jourSuivant_Click(object sender, EventArgs e)
        {
            if (jourActuel.NumJour != 499)             
                rafraichirPage(jourActuel.NumJour +1);
        }

        private void inserer_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void supprimer_Click(object sender, EventArgs e)
        {

        }

        private int tailleActivite(Activite Activitee)
        {
            return ((Activitee.HeureFin.heure - Activitee.HeureDebut.heure) * 60 + (Activitee.HeureFin.minute - Activitee.HeureDebut.minute)) / 10 * _taille10minPixel;
        }

        private void tailleChaqueCreneaux()
        {
            listEcart.Clear();
            listTailles.Clear();

            foreach (Activite i in jourActuel.ListActiviteJournee)
            {
                listTailles.Add(tailleActivite(i));
            }

            listEcart.Add(((jourActuel.ListActiviteJournee[0].HeureDebut.heure * 60 + jourActuel.ListActiviteJournee[0].HeureDebut.minute) - 0) / 10 * _taille10minPixel); // écart entre heure 0 et première activité

            for (int j = 0; j < jourActuel.ListActiviteJournee.Count() - 1; j++)
            {
                listEcart.Add(((jourActuel.ListActiviteJournee[j + 1].HeureDebut.heure * 60 + jourActuel.ListActiviteJournee[j + 1].HeureDebut.minute) - (jourActuel.ListActiviteJournee[j].HeureFin.heure * 60 + jourActuel.ListActiviteJournee[j].HeureFin.minute)) / 10 * _taille10minPixel); // écart entre 2 activités
            }

            listEcart.Add(((24 * 60 + 40 - (jourActuel.ListActiviteJournee[jourActuel.ListActiviteJournee.Count - 1].HeureFin.heure * 60 + jourActuel.ListActiviteJournee[jourActuel.ListActiviteJournee.Count - 1].HeureFin.minute))) / 10 * _taille10minPixel); // écart entre dernière activité et 24h40
        }
        
        private void afficheBoutons()
        {
            this.panelActivites.Controls.Clear();
            tailleChaqueCreneaux();
            int posX = 10, posY = 10;       

            for (int i = 0; i < jourActuel.ListActiviteJournee.Count; i++ )
            {
                Button BtnActi = new Button();
                BtnActi.Size = new Size(200, listTailles[i]);
                BtnActi.Text = (jourActuel.ListActiviteJournee[i].Descritpion);
                BtnActi.Location = (new Point(posX, posY + (jourActuel.ListActiviteJournee[i].HeureDebut.heure * 6 + jourActuel.ListActiviteJournee[i].HeureDebut.minute / 10) * _taille10minPixel));
                BtnActi.Tag = jourActuel.ListActiviteJournee[i];                
                BtnActi.Name = jourActuel.ListActiviteJournee[i].HeureDebut.ToString();

                Label label = new Label();
                label.Name = "labelActivites";
                label.Location = new Point(posX + 210, posY + (jourActuel.ListActiviteJournee[i].HeureDebut.heure * 6 + jourActuel.ListActiviteJournee[i].HeureDebut.minute / 10) * _taille10minPixel);
                label.Text = jourActuel.ListActiviteJournee[i].HeureDebut.ToString();                

                this.panelActivites.Controls.Add(BtnActi);
                this.panelActivites.Controls.Add(label);
                BtnActi.Click += activite_Click;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void activite_Click(object sender, EventArgs e)
        {
            //string DebutActi = ((Button)sender).Name.ToString();
            Activite btn_acti = ((Button)sender).Tag as Activite;

            Form3 f3 = new Form3(this.calendrierActuel, this.calendrierActuel.ListJournees.ElementAt(jourActuel.NumJour), btn_acti);            
            DialogResult dialogresult = f3.ShowDialog();
            f3.Dispose();
        }

#endregion

    }
}
