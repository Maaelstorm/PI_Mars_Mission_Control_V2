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
			// Chargement des informations générales :
 			// - Nom du fichier image (carte)
			// - position de l'habitat
			// - nombre et nom de chaque astronaute
			// - hiérarchie des activité 
			// - description des activités de la journée par défaut
									
			// Création d'un variable Restaurant qui sera utilisé pour la déserialisation
			//Calendrier cal = null;

			//if (File.Exists("./..//..//InfoGenerales.xml"))
			//{
			//    XmlSerializer xs = new XmlSerializer(typeof(Calendrier));
			//    using (StreamReader sr = new StreamReader("./..//..//InfoGenerales.xml"))
			//    {
			//        cal = xs.Deserialize(sr) as Calendrier;
			//        //Console.WriteLine("Interface de gestion du restaurant \"{0}\" - Bienvenue {1}", restaurant.Nom, restaurant.NomProprio);
			//        //Console.WriteLine("\nAppuyez sur une touche pour continuer");
			//        //Console.ReadKey();
			//    }
			//}

			//if (File.Exists("./..//..//CalendrierListes.xml"))
			//{
			//    XmlSerializer test = new XmlSerializer(typeof(Calendrier));
			//    FileStream xmlFichier = new FileStream("./..//..//CalendrierListes.xml", FileMode.Open, FileAccess.Read);
			//    xmlFichier.Seek(0, System.IO.SeekOrigin.Begin);
			//    cal = (Calendrier)test.Deserialize(xmlFichier);
			//    xmlFichier.Close();
			//}



			// Chargement des journées et des activités :


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


			// Régions par personne pour tester des fonctionnalitées
			// PENSEZ à commenter l'intérieur des région avant de commit ! Thanks !!!

#region ANTOINE

			//Calendrier cal = new Calendrier();
			//cal.JourDebutMission = new DateTime(2015, 10, 01);
			//Dates h0 = new Dates(0, 0, 0);
			//Dates h7 = new Dates(0, 7, 0);
			//Dates h8 = new Dates(0, 8, 0);
			//Dates h12 = new Dates(0, 12, 0);
			//Dates h14 = new Dates(0, 14, 0);
			//Dates h19 = new Dates(0, 19, 0);
			//Dates h21 = new Dates(0, 21, 0);
			//Dates h23 = new Dates(0, 23, 0);
			//Dates h24_40 = new Dates(0, 24, 40);

			//Coordonnees baseMission = new Coordonnees("base",new Point(0,0));
			//string sleeping = "Sleeping";
			//string eating = "Eating";
			//string prive = "Private";
			//string CompteRendu = "";
			//List<Spationaute> listeSpationaute = new List<Spationaute>();

			////on ajoute les activites par defaut de la journee.
            
			//for (int i = 0; i < 20; i++)
			//{
			//    cal.ListJournees.Add(new Journee(i));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(sleeping, h0, h7, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(eating, h7, h8, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(prive, h8, h12, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(eating, h12, h14, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(prive, h14, h19, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(eating, h19, h21, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(prive, h21, h23, baseMission, CompteRendu, listeSpationaute));
			//    cal.ListJournees[i].ListActiviteJournee.Add(new Activite(sleeping, h23, h24_40, baseMission, CompteRendu, listeSpationaute));
			//}
            

#endregion


#region FLORIE-ANNE





#endregion


#region SAM


			// Application.Run(new TestSam());
			//Form1 f1 = new Form1();
			//f1.Cal.ListJournees.ElementAt(37).ListActiviteJournee
			//f1.Cal.enregistrer();

#endregion

		}
    }
}
