using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Serialization;


namespace PI_Mars_Mission_Control
{
	[XmlRoot("activite")]
	public class Activite
	{

#region Accesseurs & Propriétés

		private Dates _heureDebut;
		[XmlElement("HeureDebut")]
		public Dates HeureDebut
		{
			get { return _heureDebut; }
			set { _heureDebut = value; }
		}

		private Dates _heureFin;
		[XmlElement("HeureFin")]
		public Dates HeureFin
		{
			get { return _heureFin; }
			set { _heureFin = value; }
		}

		private Coordonnees _lieu;
		[XmlElement("Coordonnees")]
		public Coordonnees Lieu
		{
			get { return _lieu; }
			set { _lieu = value; }
		}
		
		private string _texteDescriptif;
		[XmlElement("TexteDescriptif")]
		public string TexteDescritpif
		{
			get { return _texteDescriptif; }
			set { _texteDescriptif = value; }
		}
		
		private List<Spationaute> _listSpationaute;
		[XmlArray("Spationautes")]
		public List<Spationaute> ListSpationaute
		{
			get { return _listSpationaute; }
			set { _listSpationaute = value; }
		}
		

#endregion


#region constructeur

		// A MODIFIER 
		public Activite(Dates hdeb,Dates hfin, Coordonnees lieu, string texte, List<Spationaute> listSpatio)
		{
			if (hdeb == null)
			{
				this.HeureDebut = null;
			}
			else
			{
				this.HeureDebut = hdeb;
			}

			if (hfin == null)
			{
				this.HeureFin = null;
			}
			else
			{
				this.HeureFin = hfin;
			}

			this.Lieu = lieu;
			this.TexteDescritpif = texte;

		}

#endregion


#region méthodes

		public void serializer()
		{
			XmlSerializer xs = new XmlSerializer(typeof(Activite));
			// Ouverture de l'instance d'écriture en précisant le chemin du fichier
			using (TextWriter writer = new StreamWriter("./..//..//InfoGenerales.xml"))
			{
				xs.Serialize(writer, this);
			}

			Console.WriteLine(string.Format("Restaurant : enregistrement réussi"));
		}


		public void enregister()
        {
            throw new System.NotImplementedException();
        }

        public void rechercheLieuExploration()
        {
            throw new System.NotImplementedException();
		}

#endregion


	}
}
