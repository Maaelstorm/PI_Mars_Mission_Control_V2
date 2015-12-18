using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;


namespace Mars_Mission_Control_Dev
{
    public partial class Form1 : Form
    {

        #region Accesseurs & Propriétés

        // une période = 50 jours
        private int _period = 0; 
        private int Period
        {
            get { return _period; }
            set
            {
                _period = value;
                refreshBouttons();
            }
        }

        //  pour les positions des boutons
        private int posX = 0;
        private int posY = 0; 

        private List<Button> _listBtnJour;
        public List<Button> ListBtnJour
        {
            get { return _listBtnJour; }
            set { _listBtnJour = value; }
        }

        private Calendrier _cal;
        public Calendrier Cal
        {
            get { return _cal; }
            set { _cal = value; }
        }
        
        private List<int> _listJourneeNumAffichage = new List<int>();
        public List<int> ListJourneeNumAffichage
        {
            get { return _listJourneeNumAffichage; }
            set { _listJourneeNumAffichage = value; }
        }

        #endregion

        #region Constructeur

        public Form1()
        {
            // ListJourneeNumAffichage contient les numéros de toutes les journées affichées. Par défaut, on lui donne toutes les valeurs de 1 à 500.
            // On lui associe de nouvelles valeurs lorsqu'on utilise la fonction recherche.
            for (int i = 1; i <= 500; i++) 
            {
                this.ListJourneeNumAffichage.Add(i);
            }

            this.StartPosition = FormStartPosition.CenterScreen;
           
            InitializeComponent();

            chargementXML();

            Cal.JourDebutMission = new DateTime(2015, 12, 01);
                       
            Cal.JourActuel = Cal.conversionHeureMartienne(DateTime.Now).Jour;

            // Si le calenderier n'a pas été chargé via la déserialisation
            if (Cal.ListJournees.Count == 0)
            {
                // Création des jours
                for (int i = 0; i < 500; i++)
                {
                    Journee jour = new Journee(i + 1);

                    Cal.ListJournees.Add(jour);

                    // NE marche pas à corriger
                    for (int j = 0; j < Cal.ListActiviteDefaut.Count; j++)
                    {
                        Cal.ListActiviteDefaut.ElementAt(j).HeureDebut.Jour = jour.NumJour;
                        Cal.ListActiviteDefaut.ElementAt(j).HeureFin.Jour = jour.NumJour;
                    }

                    // Ajout de toutes les activités par défaut à la journée
                    Cal.ListJournees.ElementAt(i).ListActiviteJournee.AddRange(Cal.ListActiviteDefaut);
                }

            }   //fin if Journees.count==0        


            // Création et gestion des boutons
            if (this.ListBtnJour == null)
            {
                ListBtnJour = new List<Button>();
            }
            for (int i = Period * 50; i < (Period + 1) * 50; i++)
            {
                Button btn_jour = new Button();
                ListBtnJour.Add(btn_jour);

                btn_jour.Size = new Size(70, 50);

                // Pour le chargement de la 1ère page du calendrier : on sait que le numéro du jour va de 1 à 50
                btn_jour.Text = btn_jour.Name = ListJourneeNumAffichage[i].ToString();
                btn_jour.Location = new Point(50 + (posX * 80), 160 + (posY * 60));
                posX++;

                //mise à jour des positions, si x depasse le nombre max d'elements en horizontal, on passe à la ligne suivante
                if (posX >= 10)
                {
                    posX = 0;
                    posY++;
                }

                this.Controls.Add(btn_jour);
                btn_jour.Click += jour_Click;//fonction de click sur le Btn_jour

                //gestion de la couleur 
                if (int.Parse(btn_jour.Name) < Cal.JourActuel)
                    btn_jour.BackColor = Color.LightGray;
                else if (int.Parse(btn_jour.Name) == Cal.JourActuel)
                    btn_jour.BackColor = Color.LightBlue;
                else
                    btn_jour.BackColor = Color.LimeGreen;
            }
            // on ajoute les activités par défaut dans la liste à cocher
            string[] nomsActivites = new string[Cal.ListActiviteDefaut.Count];
            for (int i = 0; i < nomsActivites.Length; i++)
            {
                nomsActivites[i] = Cal.ListActiviteDefaut[i].Nom;
            }
            foreach (string unNomAct in nomsActivites)
            {
                this.clb_activites.Items.Add(unNomAct, true);
            }
            this.clb_activites.Items.AddRange(nomsActivites);
        }//end of constructor

        #endregion

        #region Méthodes


        private void chargementXML()
        {
            // Toutes les données sont sérialisées dans le même document 
            if (File.Exists("./..//..//Calendrier.xml"))
            {
                XmlSerializer test = new XmlSerializer(typeof(Calendrier));
                FileStream xmlFichier = new FileStream("./..//..//Calendrier.xml", FileMode.Open, FileAccess.Read);
                xmlFichier.Seek(0, System.IO.SeekOrigin.Begin);
                Cal = (Calendrier)test.Deserialize(xmlFichier);
                xmlFichier.Close();
            }

            // Chargement de la liste d'activitée par défaut :
            else if (File.Exists("./..//..//ListeActiviteDefaut.xml"))
            {
                XmlSerializer test = new XmlSerializer(typeof(Calendrier));
                FileStream xmlFichier = new FileStream("./..//..//ListeActiviteDefaut.xml", FileMode.Open, FileAccess.Read);
                xmlFichier.Seek(0, System.IO.SeekOrigin.Begin);
                Cal = (Calendrier)test.Deserialize(xmlFichier);
                xmlFichier.Close();
            }
        }

        private void refreshBouttons()
        {
            int numBtn;
            int numJour;
            // au passage à une autre période, on renomme les boutons
            for (int i = 0; i <= 49; i++)
            {
                numBtn = Period * 50 + i;
                if (numBtn <= ListJourneeNumAffichage.Count - 1)
                {
                    ListBtnJour[i].Visible = true;
                    ListBtnJour[i].Text = ListJourneeNumAffichage[numBtn].ToString();
                }
                else
                {
                    ListBtnJour[i].Visible = false;
                }
                numJour = int.Parse(ListBtnJour[i].Text);
                // couleurs des boutons liés à la journée en cours                   
                if (numJour < Cal.JourActuel)
                    ListBtnJour[i].BackColor = Color.Silver;
                else if (numJour == Cal.JourActuel)
                    ListBtnJour[i].BackColor = Color.LightSkyBlue;
                else
                    ListBtnJour[i].BackColor = Color.LimeGreen;
            }
        }
        
        private void jour_Click(object sender, EventArgs e)
        {
            int NumJour = int.Parse(((Button)sender).Text.ToString()) - 1; // on récupère le numéro du jour sur lequel l'utilisateur a cliqué

            using (var f2 = new Form2(this.Cal, this.Cal.ListJournees.ElementAt(NumJour))) // on ouvre le Form2 de ce jour précis
            {
                f2.FormClosing += delegate { this.Show(); };
                this.Hide();
                f2.ShowDialog();
            }
        }

        private void joursSuivants_Click(object sender, EventArgs e) 
        {
            // on passe à la période suivante (50 jours suivants)
            if (Period < ListJourneeNumAffichage.Count / 50 && Period <= 8)
            {
                Period++;
            }
        }

        private void joursPrecedents_Click(object sender, EventArgs e)
        {
            // on passe à la période précédente (50 jours précédents)
            if (Period > 0)
            {
                Period--;
            }
        }

        #region fonctionRecherche
        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // on enregistre les modifications apportées au calendrier
            this.Cal.enregistrer(); 
        }

        private void tb_rechercheDescAct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_goRecherche_Click(object sender, EventArgs e)
            // modifie la liste des journées à afficher en fonction des critère rentrés dans le formulaire de recherche.
        {
            int jourDeb, jourFin;
            if (tb_jourDebut.Text != string.Empty) jourDeb = Int32.Parse(tb_jourDebut.Text);
            else jourDeb = 0;
            if (tb_jourFin.Text != string.Empty) jourFin = Int32.Parse(tb_jourFin.Text);
            else jourFin = Cal.ListJournees.Count;
            string descAct = tb_rechercheDescAct.Text;
            List<string> nomAct = new List<string>();
            foreach (object actChecked in clb_activites.CheckedItems)
            {
                nomAct.Add(actChecked.ToString());
            }
            string rechercheCR = tb_rechercheCR.Text;
            bool actExt = cb_activiteExt.Checked;
            List<Journee> ListJourneeAffichage = Cal.rechercheJournee(nomAct, descAct, rechercheCR, jourDeb, jourFin);
            List<int> ListNumTmp = new List<int>();
            foreach (Journee uneJournee in ListJourneeAffichage)
            {
                ListNumTmp.Add(uneJournee.NumJour);
            }
            ListJourneeNumAffichage = ListNumTmp;
            // on affiche à l'utilisateur un texte disant qu'il est dans une recherche, ainsi que le bouton pour revenir
            // au calendrier de base
            btn_retour_recherche.Visible = true;
            lb_resultatsRecherche.Visible = true;
            //on raffraichit l'affichage des boutons.
            refreshBouttons();
        }
        #endregion

        private void clb_activites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btn_leaveApp_Click(object sender, EventArgs e)
        {
            this.Cal.enregistrer();
            this.Close();
        }

        private void btn_retour_recherche_Click(object sender, EventArgs e)
        {
            this.btn_retour_recherche.Visible = false;
            lb_resultatsRecherche.Visible = false;
            //on change la liste des journes à afficher pour lui redonner sa valeur par défaut
            List<int> ListProv = new List<int>();
            for (int i=1;i<=500;i++)
            {
                ListProv.Add(i);
            }
            ListJourneeNumAffichage=ListProv;
            refreshBouttons();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void cb_activiteExt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
