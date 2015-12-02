using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PI_Mars_Mission_Control
{
    public class Coordonnees
    {
        public Point Position
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Image Icone
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Descriptif
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

		public Coordonnees()
		{

		}

        public Coordonnees(Point point, /*Image Icone,*/ string descriptif)
        {
            this.Position = point;
           // this.Icone = Icone;
            this.Descriptif = descriptif;
        }
    }
}
