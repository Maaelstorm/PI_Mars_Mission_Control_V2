using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;


// SAM
namespace PI_Mars_Mission_Control
{
	[XmlRoot("Carte")]
	public class Carte
	{

#region Accesseurs & Propriétés

		private List<Image> _listIcone;
		[XmlArray("ListeIcone")]
		[XmlArrayItem("Icone", typeof(Image))]
		public List<Image> ListIcone
		{
			get { return _listIcone; }
			set { _listIcone = value; }
		}

		private Image _imageZone;
		[XmlElement("ImageZone")]
		public Image ImageZone
		{
			get { return _imageZone; }
			set { _imageZone = value; }
		}

		private List<Coordonnees> _listCoordonnees;
		[XmlArray("Coordonnees")]
		public List<Coordonnees> ListCoordonnees
		{
			get { return _listCoordonnees; }
			set { _listCoordonnees = value; }
		}

#endregion

#region Constructeur

		// Constructeur
		public Carte()
		{
			this.ImageZone = Image.FromFile("./..//..//nanedi_valles.jpg");
			this.ListIcone = new List<Image>();
			this.ListCoordonnees = new List<Coordonnees>();
		}

		// Méthode d'ouverture de fichier A FAIRE DANS LE FORM si choix de la carte de la zone par l'utilisateur
		public Carte(string path)
		{
			this.ImageZone = Image.FromFile(path);
			this.ListIcone = new List<Image>();
			this.ListCoordonnees = new List<Coordonnees>();
		}

#endregion


#region Méthodes

		public void serializer()
		{
			XmlSerializer xs = new XmlSerializer(typeof(Carte));
			// Ouverture de l'instance d'écriture en précisant le chemin du fichier
			using (TextWriter writer = new StreamWriter("./..//..//InfoGenerales.xml"))
			{
				xs.Serialize(writer, this);
			}

			Console.WriteLine(string.Format("Carte : enregistrement réussi"));
		}

		public void ajouterCoord(string nom, int x, int y)
		{
			Point pt = new Point(x,y);
			Coordonnees cord = new Coordonnees(nom, pt);
			this.ListCoordonnees.Add(cord);
		}

		public void selectCoord(int x, int y)
		{
			throw new System.NotImplementedException();
		}

#endregion

	}
}
