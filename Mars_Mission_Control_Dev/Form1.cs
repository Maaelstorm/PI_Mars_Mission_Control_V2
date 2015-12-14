﻿using System;
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
        
        private int posX = 0;
        private int posY = 0;

        public Button btn_jour { get; set; }


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

            for (int i=1; i<=500;i++)
            {
                this.ListJourneeNumAffichage.Add(i);
            }

			this.StartPosition = FormStartPosition.CenterScreen;
                        
            InitializeComponent();
			
			chargementXML();

            Cal.JourDebutMission = new DateTime(2015, 12, 01);
            
            // conversionHeureMartienne A corriger pour que la ligne marche :
             Cal.JourActuel = Cal.conversionHeureMartienne(DateTime.Now).Jour;

			// Si le calenderier n'a pas été chargé via la déserialisation
			if (Cal.ListJournees.Count == 0)
			{
				// Création des jours
				for (int i = 0; i < 500; i++)
				{
					Journee jour = new Journee(i+1);
					
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
            for (int i = Period*50; i < (Period+1)*50; i++)
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
                    btn_jour.BackColor = Color.LightGreen;
            }

            string[] nomsActivites = new string[Cal.ListActiviteDefaut.Count];
            for (int i = 0; i < nomsActivites.Length; i++)
            {
                nomsActivites[i] = Cal.ListActiviteDefaut[i].Nom;
            }
            //foreach (string unNomAct in nomsActivites)
            //{
            //    this.clb_activites.Items.Add(unNomAct, true);
            //}
            this.clb_activites.Items.AddRange(nomsActivites);
        }//end of constructor

        #endregion

        #region Méthodes


		private void chargementXML()
		{
			//Chargement des informations générales :
			//- Nom du fichier image (carte)
			//- position de l'habitat

			//- nombre et nom de chaque astronaute
			//- hiérarchie des activité 
			//- description des activités de la journée par défaut
			
			//if (File.Exists("./..//..//InfoGenerales.xml"))
			//{
			//    XmlSerializer xs = new XmlSerializer(typeof(Calendrier));
			//    using (StreamReader sr = new StreamReader("./..//..//InfoGenerales.xml"))
			//    {
			//        Cal = xs.Deserialize(sr) as Calendrier;
			//        //Console.WriteLine("Interface de gestion du restaurant \"{0}\" - Bienvenue {1}", restaurant.Nom, restaurant.NomProprio);
			//        //Console.WriteLine("\nAppuyez sur une touche pour continuer");
			//        //Console.ReadKey();
			//        sr.Close();
			//    }
			//}

			// Chargement de la liste d'activitée par défaut :
			if (File.Exists("./..//..//ListeActiviteDefaut.xml"))
			{
				XmlSerializer test = new XmlSerializer(typeof(Calendrier));
				FileStream xmlFichier = new FileStream("./..//..//ListeActiviteDefaut.xml", FileMode.Open, FileAccess.Read);
				xmlFichier.Seek(0, System.IO.SeekOrigin.Begin);
				Cal = (Calendrier)test.Deserialize(xmlFichier);
				xmlFichier.Close();
			}
			
			// Toutes les données sont sérialisées dans le même document 
			if (File.Exists("./..//..//Calendrier.xml"))
			{
				XmlSerializer test = new XmlSerializer(typeof(Calendrier));
				FileStream xmlFichier = new FileStream("./..//..//Calendrier.xml", FileMode.Open, FileAccess.Read);
				xmlFichier.Seek(0, System.IO.SeekOrigin.Begin);
				Cal = (Calendrier)test.Deserialize(xmlFichier);
				xmlFichier.Close();
			}
		}

        private void refreshBouttons()
        {
            int numBtn;
            for (int i = 0; i <= 49; i++)
            {
                //on change la valeur des bouttons
                numBtn = Period * 50 + i;
                ListBtnJour[i].Text = ListJourneeNumAffichage[numBtn].ToString();

                //color                    
                if (numBtn < Cal.JourActuel)
                    ListBtnJour[i].BackColor = Color.LightGray;
                else if (numBtn == Cal.JourActuel)
                    ListBtnJour[i].BackColor = Color.LightBlue;
                else
                    ListBtnJour[i].BackColor = Color.LightGreen;
            }
        }

        private void jour_Click(object sender, EventArgs e)
        {            
            int NumJour = int.Parse(((Button)sender).Text.ToString()) - 1;

            using (var f2 = new Form2(this.Cal, this.Cal.ListJournees.ElementAt(NumJour)))
            {
                f2.FormClosing += delegate { this.Show(); };
                this.Hide();
                f2.ShowDialog();
            }
        }


        private void joursSuivants_Click(object sender, EventArgs e)
        {
            //Button tmpBtn;
            if (Period < 9)
            {
                Period++;
            }
        }


        private void joursPrecedents_Click(object sender, EventArgs e)
        {
            //Button tmpBtn;
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
			this.Cal.enregistrer();
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_rechercheDescAct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_goRecherche_Click(object sender, EventArgs e)
        {
            int jourDeb, jourFin;
            if (tb_jourDebut.Text != string.Empty) jourDeb = Int32.Parse(tb_jourDebut.Text);
            else jourDeb = 0;
            if (tb_jourFin.Text != string.Empty) jourFin = Int32.Parse(tb_jourFin.Text);
            else jourFin = Cal.ListJournees.Count;
            string descAct = tb_rechercheDescAct.Text;
            string nomAct = clb_activites.CheckedItems.ToString();
            string rechercheCR= tb_rechercheCR.Text;
            bool actExt = cb_activiteExt.Checked;
            List<Journee> ListJourneeAffichage = Cal.rechercheJournee(nomAct, descAct, rechercheCR, jourDeb, jourFin);
            List<int> ListNumTmp = new List<int>();
            foreach (Journee uneJournee in ListJourneeAffichage)
            {
                ListNumTmp.Add(uneJournee.NumJour);
            }
            ListJourneeNumAffichage = ListNumTmp;
            refreshBouttons();
        }
#endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clb_activites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Cal.enregistrer();
            this.Close();
        }

       

    }
}
