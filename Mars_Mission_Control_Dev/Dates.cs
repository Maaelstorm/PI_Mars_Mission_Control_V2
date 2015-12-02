using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_Mars_Mission_Control
{
	public class Dates
    {
        public int heure;

		public int minute;
		
        public int jour;

        public Dates(int j, int h, int m)
        {
            heure = h;
            minute = m;
            jour = j;
        }

        public override string ToString()
        {
             return String.Format("{0}:{1}",this.heure, this.minute);
        }
    }
}
