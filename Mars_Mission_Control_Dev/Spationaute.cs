using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using System.Xml.Serialization;


namespace Mars_Mission_Control_Dev
{
    [XmlRoot("Spationaute")]
	public class Spationaute
	{

        private string _nom;
        [XmlElement("Nom")]
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

		// Constructeur par défaut pour la sérialisation
		public Spationaute()
		{
			this.Nom = "serialisation";
		}

		public Spationaute(string nom)
		{
			this.Nom = nom;
		}


		/// <summary>
		/// Permet de générer la partie XML de Astronaute
		/// </summary>
		/// <param name="xmlCalendrierListe">XmlDocument global</param>
		/// <param name="xmlInfosGénérales">XmlDocument pour les activités de base</param>
		/// <param name="astronaute">Le noeud de l'astronaute</param>
		/// <param name="acts">Le noeud de l'activité (base)</param>
		public void enregistrer(XmlDocument xmlCalendrierListe, XmlDocument xmlInfosGénérales, XmlNode astronaute, XmlNode acts)
		{
			//string nom, Dates hdeb,Dates hfin, Coordonnees lieu, string desc, List<Spationaute> listSpatio

			XmlNode nom = xmlCalendrierListe.CreateElement("Nom");
			nom.InnerText = this.Nom;
			astronaute.AppendChild(nom);
			
				//this.ListSpationaute[i].enregistrer(xmlCalendrierListe, xmlInfosGénérales, journee, acts);
			
		}


	}
}
