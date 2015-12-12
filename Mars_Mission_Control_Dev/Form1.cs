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


        private int period = 1;
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
        		
        #endregion


        #region Constructeur

        public Form1()
        {
			this.StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();
			
			chargementXML();

            Cal.JourDebutMission = new DateTime(2015, 12, 01);
            
            // conversionHeureMartienne A corriger pour que la ligne marche :
             Cal.JourActuel = Cal.conversionHeureMartienne(DateTime.Now).Jour;


            // Test en dur à commenter si heure martienne marche
            //Cal.JourActuel = 25;



			//On ajoute toutes les activités par défaut

            //Cal = new Calendrier();

            //Coordonnees QG = new Coordonnees("Base", new Point(0, 0));
            //Activite Sleeping1 = new Activite("Sleeping1", new Dates(0, 0, 0), new Dates(0, 7, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Eating1 = new Activite("Eating", new Dates(0, 7, 0), new Dates(0, 8, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Private1 = new Activite("private", new Dates(0, 8, 0), new Dates(0, 12, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Eating2 = new Activite("Eating", new Dates(0, 12, 0), new Dates(0, 14, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Private2 = new Activite("Private", new Dates(0, 14, 0), new Dates(0, 19, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Eating3 = new Activite("Eating", new Dates(0, 19, 0), new Dates(0, 21, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Private3 = new Activite("Private", new Dates(0, 21, 0), new Dates(0, 23, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
            //Activite Sleeping2 = new Activite("Sleeping", new Dates(0, 23, 0), new Dates(0, 24, 40), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);

            //Cal.ListActiviteDefaut.Add(Sleeping1);
            //Cal.ListActiviteDefaut.Add(Eating1);
            //Cal.ListActiviteDefaut.Add(Private1);
            //Cal.ListActiviteDefaut.Add(Eating2);
            //Cal.ListActiviteDefaut.Add(Private2);
            //Cal.ListActiviteDefaut.Add(Eating3);
            //Cal.ListActiviteDefaut.Add(Private3);
            //Cal.ListActiviteDefaut.Add(Sleeping2);



			// Si le calenderier n'a pas été chargé via la déserialisation
			if (Cal.ListJournees.Count == 0)
			{
				// Création des jours
				for (int i = 0; i < 500; i++)
				{
					Journee jour = new Journee(i+1);
					jour.CompteRendu = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque dolore magnam aliquam quaerat voluptatem. Ut enim quo voluptas nulla pariatur?";

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

                


				// TEST A SUPPRIMER si plus besoin 

				//int index = 0;
				//foreach (var item in Cal.ListJournees)
				//{
				//    Coordonnees QG = new Coordonnees("Base", new Point(0, 0));
				//    Activite Sleeping1 = new Activite("Sleeping", new Dates(item.NumJour, 0, 0), new Dates(item.NumJour, 7, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Sleeping2 = new Activite("Sleeping", new Dates(item.NumJour, 23, 0), new Dates(item.NumJour, 24, 40), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Eating1 = new Activite("Eating", new Dates(item.NumJour, 7, 0), new Dates(item.NumJour, 8, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Eating2 = new Activite("Eating", new Dates(item.NumJour, 12, 0), new Dates(item.NumJour, 14, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Eating3 = new Activite("Eating", new Dates(item.NumJour, 19, 0), new Dates(item.NumJour, 21, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Private1 = new Activite("Eating", new Dates(item.NumJour, 8, 0), new Dates(item.NumJour, 12, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Private2 = new Activite("Private", new Dates(item.NumJour, 14, 0), new Dates(item.NumJour, 19, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);
				//    Activite Private3 = new Activite("Private", new Dates(item.NumJour, 21, 0), new Dates(item.NumJour, 23, 0), QG, "CHANGER LA DESCRIPTION EN NOM", Cal.ListSpationaute);

				//    item.ListActiviteJournee.Add(Sleeping1);


				//    if (index % 1 == 0)
				//        item.ListActiviteJournee.Add(Sleeping2);
				//    if (index % 2 == 0)
				//        item.ListActiviteJournee.Add(Eating1);
				//    if (index % 6 == 0)
				//        item.ListActiviteJournee.Add(Eating2);
				//    if (index % 3 == 0)
				//        item.ListActiviteJournee.Add(Eating3);
				//    if (index % 8 == 0)
				//        item.ListActiviteJournee.Add(Private1);
				//    if (index % 6 == 0)
				//        item.ListActiviteJournee.Add(Private2);
				//    if (index % 4 == 0)
				//        item.ListActiviteJournee.Add(Private3);
				//    item.ListActiviteJournee.Sort(
				//        delegate(Activite a1, Activite a2) // Et on les ordonne
				//        {
				//            int HA1 = a1.HeureDebut.Heure * 60 + a1.HeureDebut.Minute;
				//            int HA2 = a2.HeureDebut.Heure * 60 + a2.HeureDebut.Minute;
				//            return HA1.CompareTo(HA2);
				//        });

				//    index++;
				//}
			}   //fin if Journees.count==0        


			// Création et gestion des boutons
            if (this.ListBtnJour == null)
            {
                ListBtnJour = new List<Button>();
            }

            for (int i = 1; i <= 50; i++)
            {
                Button btn_jour = new Button();
                ListBtnJour.Add(btn_jour);

                btn_jour.Size = new Size(70, 50);

                // Pour le chargement de la 1ère page du calendrier : on sait que le numéro du jour va de 1 à 50
                btn_jour.Text = btn_jour.Name = i.ToString();
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
            Button tmpBtn;
            if (period < 10)
            {
                period++;

                for (int i = 0; i < 50; i++)
                {
                    tmpBtn = ListBtnJour.ElementAt(i);
                    int tmp = int.Parse((ListBtnJour.ElementAt(i).Text.ToString())); //On récupère la valeur du numéro du jour
                    tmp += 50; // On lui ajoute 50
                    tmpBtn.Text = tmp.ToString(); // Et on la remplace

                    //color                    
                    if (tmp < Cal.JourActuel)
                        tmpBtn.BackColor = Color.LightGray;
                    else if (tmp == Cal.JourActuel)
                        tmpBtn.BackColor = Color.LightBlue;
                    else
                        tmpBtn.BackColor = Color.LightGreen;

                }
            }
        }


        private void joursPrecedents_Click(object sender, EventArgs e)
        {
            Button tmpBtn;
            if (period > 1)
            {
                period--;

                for (int i = 0; i < 50; i++)
                {
                    tmpBtn = ListBtnJour.ElementAt(i);
                    int tmp = int.Parse((ListBtnJour.ElementAt(i).Text.ToString())); // On récupère la valeur du numéro du jour
                    tmp -= 50; // On lui enlève 50
                    tmpBtn.Text = tmp.ToString(); // Et on la replace

                    //color                    
                    if (tmp < Cal.JourActuel)
                        tmpBtn.BackColor = Color.LightGray;
                    else if (tmp == Cal.JourActuel)
                        tmpBtn.BackColor = Color.LightBlue;
                    else
                        tmpBtn.BackColor = Color.LightGreen;
                }
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
            int jourDeb=Int32.Parse(tb_jourDebut.Text);
            int jourFin=Int32.Parse(tb_jourFin.Text);
            string descAct = tb_rechercheDescAct.Text;
            string nomAct = clb_activites.CheckedItems.ToString();
            bool actExt = cb_activiteExt.Checked;
            List<Journee> joursRecherche = new List<Journee>();
        }
#endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clb_activites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
