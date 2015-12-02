using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PI_Mars_Mission_Control
{
	public class Coordonnees
	{

		#region accesseurs & proprietés

		private Point _position;
		public Point Position
		{
			get { return _position; }
			set { _position = value; }
		}

		private Image _icone;
		public Image Icone
		{
			get { return _icone; }
			set { _icone = value; }
		}

		private string _descriptif;
		public string Descriptif
		{
			get { return _descriptif; }
			set { _descriptif = value; }
		}

		#endregion

		#region constructeurs

		public Coordonnees()
		{
			Position = new Point();
			Icone = null;
			Descriptif = "";
		}
		public Coordonnees(Point point)
			: this()
		{
			Position = point;
		}
		public Coordonnees(Point point, string descriptif)
			: this()
		{
			this.Position = point;
			this.Descriptif = descriptif;
		}
		public Coordonnees(Point point, Image Icone, string descriptif)
			: this(point, descriptif)
		{
			this.Icone = Icone;
		}

		#endregion

		#region methodes

		public double distance(Point point)
		{
			double ecartX = this.Position.X - point.X;
			double ecartY = this.Position.Y - point.Y;
			return Math.Sqrt(ecartX * ecartX + ecartY * ecartY);
		}

		#endregion

	}
}