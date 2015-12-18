using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Mission_Control_Dev
{
    public class Journee
    {
        public Journee()
        {
            throw new System.NotImplementedException();
        }

		public string CompteRendu
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
		}

		public static int NumJour
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public List<Activite> ListActiviteJournee
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
        }

        public List<Activite> checkActivite()
        {
            throw new System.NotImplementedException();
        }

        public bool recherche()
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> rechercheNomActivite()
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> rechercheDescActivite()
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> selectionPeriode(Dates HeureDeb, Dates HeureFin)
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> selectionPeriode(int HeureDeb, int HeureFin)
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> rechercheLieuExploration(System.Drawing.Point hg, System.Drawing.Point bd, Dates HeureDeb, Dates HeureFin)
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> rechercheLieuExploration(System.Drawing.Point hg, System.Drawing.Point bd, int HeureDeb, int HeureFin)
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> rechercheSorties(Dates HeureDeb, Dates HeureFin)
        {
            throw new System.NotImplementedException();
        }

        public List<Activite> rechercheSorties(int HeureDeb, int HeureFin)
        {
            throw new System.NotImplementedException();
        }

        public Tuple<Dates, Dates> int2Dates(int HeureDeb, int HeureFin)
        {
            throw new System.NotImplementedException();
        }
    }
}
