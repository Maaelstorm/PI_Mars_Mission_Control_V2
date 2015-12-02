using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;


namespace PI_Mars_Mission_Control
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
        

        public Spationaute()
        {
            throw new System.NotImplementedException();
        }


		public List<Activite> afficherActiviteSpationaute()
		{
			throw new System.NotImplementedException();
		}
	}
}
