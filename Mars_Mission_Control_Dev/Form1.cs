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
    public partial class Form1 : Form
	{


#region Accesseurs & Propriétés


		private int period = 1;
        private int jourActuel = 25;
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
            InitializeComponent();

			//Création d'un calendrier pour gérer la liste des journées (plus en statique dans la classe Journee)			
            Cal = new Calendrier();            
				
			for (int i = 0; i < 500; i++)
			{
				Journee jour = new Journee(i,Cal.ListJournees);
                jour.CompteRendu = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque dolore magnam aliquam quaerat voluptatem. Ut enim quo voluptas nulla pariatur?";
                jour.ListActiviteJournee = new List<Activite>();
			}
			

			if (this.ListBtnJour == null)
			{
				ListBtnJour = new List<Button>();
			}

            for (int i = 1; i <= 50; i++)
            {
                Button btn_jour = new Button();
				ListBtnJour.Add(btn_jour);

                btn_jour.Size = new Size(50, 50);

				// Pour le chargement de la 1ère page du calendrier : on sait que le numéro du jour va de 1 à 50
				btn_jour.Text = btn_jour.Name = i.ToString();                 
                btn_jour.Location = new Point(60 + (posX * 50), 60 + (posY * 50));
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
                if (int.Parse(btn_jour.Name) < jourActuel)
                    btn_jour.BackColor = Color.LightGray;
                else if (int.Parse(btn_jour.Name) == jourActuel)
                    btn_jour.BackColor = Color.LightBlue;
                else
                    btn_jour.BackColor = Color.LightGreen;                  
                              
            }


    #region Activités par défauts

            // On ajoute toutes les activités par défaut
            int index = 0;
            foreach (var item in Cal.ListJournees)
            {
				Activite Sleeping1 = new Activite(new Dates(item.NumJour, 0, 0), new Dates(item.NumJour, 7, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Sleeping", Cal.ListSpationaute);
				Activite Sleeping2 = new Activite(new Dates(item.NumJour, 23, 0), new Dates(item.NumJour, 24, 40), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Sleeping", Cal.ListSpationaute);
				Activite Eating1 = new Activite(new Dates(item.NumJour, 7, 0), new Dates(item.NumJour, 8, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Eating", Cal.ListSpationaute);
				Activite Eating2 = new Activite(new Dates(item.NumJour, 12, 0), new Dates(item.NumJour, 14, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Eating", Cal.ListSpationaute);
				Activite Eating3 = new Activite(new Dates(item.NumJour, 19, 0), new Dates(item.NumJour, 21, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/"COUCOU"), "Eating", Cal.ListSpationaute);
				Activite Private1 = new Activite(new Dates(item.NumJour, 8, 0), new Dates(item.NumJour, 12, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Eating", Cal.ListSpationaute);
				Activite Private2 = new Activite(new Dates(item.NumJour, 14, 0), new Dates(item.NumJour, 19, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Private", Cal.ListSpationaute);
				Activite Private3 = new Activite(new Dates(item.NumJour, 21, 0), new Dates(item.NumJour, 23, 0), new Coordonnees(new Point(), /* pictureBox1.Image,*/ "COUCOU"), "Private", Cal.ListSpationaute);

                item.ListActiviteJournee.Add(Sleeping1);

                if (index % 1 == 0)
                    item.ListActiviteJournee.Add(Sleeping2);
                if (index % 2 == 0)
                    item.ListActiviteJournee.Add(Eating1);
                if (index % 6 == 0)
                    item.ListActiviteJournee.Add(Eating2);
                if (index % 3 == 0)
                    item.ListActiviteJournee.Add(Eating3);
                if (index % 8 == 0)
                    item.ListActiviteJournee.Add(Private1);
                if (index % 6 == 0)
                    item.ListActiviteJournee.Add(Private2);
                if (index % 4 == 0)
                    item.ListActiviteJournee.Add(Private3);
                item.ListActiviteJournee.Sort(
                    delegate(Activite a1, Activite a2) // Et on les ordonne
                    {
                        int HA1 = a1.HeureDebut.heure * 60 + a1.HeureDebut.minute;
                        int HA2 = a2.HeureDebut.heure * 60 + a2.HeureDebut.minute;
                        return HA1.CompareTo(HA2);
                    });

                index++;
            }

    #endregion

        }

#endregion



#region Méthodes


        private void jour_Click(object sender, EventArgs e)
        {
            int NumJour = 0;
            NumJour = int.Parse(((Button)sender).Text.ToString());
            
            using (var f2 = new Form2(this.Cal ,this.Cal.ListJournees.ElementAt(NumJour)))
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
                    if (tmp < jourActuel)
                        tmpBtn.BackColor = Color.LightGray;
                    else if (tmp == jourActuel)
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
                    if (tmp < jourActuel)
                        tmpBtn.BackColor = Color.LightGray;
                    else if (tmp == jourActuel)
                        tmpBtn.BackColor = Color.LightBlue;
                    else
                        tmpBtn.BackColor = Color.LightGreen;     
                }
            }
        }


		private void label1_Click(object sender, EventArgs e)
		{

        }

#endregion

		private void Form1_Load(object sender, EventArgs e)
		{

		}

    }
}
