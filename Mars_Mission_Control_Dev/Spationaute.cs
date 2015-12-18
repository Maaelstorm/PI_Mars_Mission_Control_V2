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
		}


		public Spationaute(string nom)
		{
			this.Nom = nom;
		}			

	}
}
