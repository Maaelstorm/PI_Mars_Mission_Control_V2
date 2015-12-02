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


		// Constructeur
		public Carte()
		{
			throw new System.NotImplementedException();
		}


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

		public void ajouterCoord(int x, int y)
		{
			throw new System.NotImplementedException();
		}

		public void selectCoord(int x, int y)
		{
			throw new System.NotImplementedException();
		}

		#endregion

	}
}
