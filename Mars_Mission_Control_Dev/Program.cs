using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;

namespace PI_Mars_Mission_Control
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
        }
    }
}
