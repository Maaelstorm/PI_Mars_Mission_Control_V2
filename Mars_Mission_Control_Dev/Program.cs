using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;

using System.Drawing;

namespace Mars_Mission_Control_Dev
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.Title = "Resto 2.0 - Gestion des réservations";
			//Console.SetWindowSize(100,45);
			
			// Chargement des données 
						
			// Création d'un variable Restaurant qui sera utilisé pour la déserialisation
			//Restaurant restaurant = null;

			//if (File.Exists("./..//..//Restaurant.xml"))
			//{
			//    XmlSerializer xs = new XmlSerializer(typeof(Restaurant));
			//    using (StreamReader sr = new StreamReader("./..//..//Restaurant.xml"))
			//    {
			//        restaurant = xs.Deserialize(sr) as Restaurant;
			//        Console.WriteLine("Interface de gestion du restaurant \"{0}\" - Bienvenue {1}", restaurant.Nom, restaurant.NomProprio);
			//        Console.WriteLine("\nAppuyez sur une touche pour continuer");
			//        Console.ReadKey();
			//    }
			//}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


			// Régions par personne pour tester des fonctionnalitées
			// PENSEZ à commenter l'intérieur des région avant de commit ! Thanks !!!

#region ANTOINE

            Calendrier cal = new Calendrier();
            cal.JourDebutMission = new DateTime(2015, 10, 01);
            Dates h0 = new Dates(0, 0, 0);
			Dates h7 = new Dates(0, 7, 0);
			Dates h8 = new Dates(0, 8, 0);
			Dates h12 = new Dates(0, 12, 0);
			Dates h14 = new Dates(0, 14, 0);
			Dates h19 = new Dates(0, 19, 0);
			Dates h21 = new Dates(0, 21, 0);
			Dates h23 = new Dates(0, 23, 0);
			Dates h24_40 = new Dates(0, 24, 40);

			Coordonnees baseMission = new Coordonnees("base",new Point(0,0));
			string sleeping = "Sleeping";
			string eating = "Eating";
			string prive = "Private";
            string CompteRendu = "";
            List<Spationaute> listeSpationaute = new List<Spationaute>();

			//on ajoute les activites par defaut de la journee.
            
            for (int i = 0; i < 20; i++)
            {
                cal.ListJournees.Add(new Journee(i));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(sleeping, h0, h7, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(eating, h7, h8, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(prive, h8, h12, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(eating, h12, h14, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(prive, h14, h19, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(eating, h19, h21, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(prive, h21, h23, baseMission, CompteRendu, listeSpationaute));
                cal.ListJournees[i].ListActiviteJournee.Add(new Activite(sleeping, h23, h24_40, baseMission, CompteRendu, listeSpationaute));
            }
            

#endregion


#region FLORIE-ANNE





#endregion


#region SAM


			//Application.Run(new TestSam());


#endregion

		}
    }
}
