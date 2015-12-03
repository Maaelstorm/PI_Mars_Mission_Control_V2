using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using System.Xml.Serialization;


// SAM
namespace Mars_Mission_Control_Dev
{
	[XmlRoot("Coordonnees")]
	public class Coordonnees
	{

#region accesseurs & proprietés

		private string _nom;
		[XmlElement("Nom")]
		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}
		
		private Point _position;
		[XmlElement("Point")]
		public Point Position
		{
			get { return _position; }
			set { _position = value; }
		}

		private Image _icone;
		[XmlElement("Icone")]
		public Image Icone
		{
			get { return _icone; }
			set { _icone = value; }
		}

		private string _descriptif;
		[XmlElement("Descriptif")]
		public string Descriptif
		{
			get { return _descriptif; }
			set { _descriptif = value; }
		}

#endregion

#region constructeurs

		public Coordonnees(string nom, Point point)
		{
			this.Nom = nom;
			this.Position = point;
			this.Icone = null;
			this.Descriptif = "";
		}

		public Coordonnees(string nom, Point point, string descriptif) : this(nom, point)
		{
			this.Position = point;
			this.Descriptif = descriptif;
		}

		public Coordonnees(string nom, Point point, Image Icone, string descriptif)	: this(nom, point, descriptif)
		{
			this.Icone = Icone;
		}

#endregion

#region methodes

		// La fonction distance renvoie la distance (sous forme d'un réel) entre 2 points 
		public double distance(Point point)
		{
			double ecartX = this.Position.X - point.X;
			double ecartY = this.Position.Y - point.Y;
			return Math.Sqrt(ecartX * ecartX + ecartY * ecartY);
		}

#endregion

	}
}