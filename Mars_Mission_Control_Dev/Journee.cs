using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;


// ANTOINE	
namespace Mars_Mission_Control_Dev
{
	[XmlRoot("Journees")]
    public class Journee
    {		

    #region Accesseurs & Propriétés

		private int _numJour;
		[XmlElement("N°Jour")]
		public int NumJour
        {
            get { return _numJour; }
            set 
			{
				if (NumJour >= 0) _numJour = value;
				else throw new System.ArgumentException("le numero du jour doit être positif");			
			}
        }

		private string _compteRendu;
		[XmlElement("CompteRendu")]
		public string CompteRendu
		{
			get { return _compteRendu; }
			set 
			{
				if (value.Length > 400) throw new System.ArgumentException("le compte rendu ne doit pas excéder 300 caractères");
				else _compteRendu = value;
			}
		}

		private List<Activite> _listActiviteJournee;
		[XmlArray("ListeActivitees")]
		public List<Activite> ListActiviteJournee
		{
			get { return _listActiviteJournee; }
			set { _listActiviteJournee = value; }
		}
			
		
#endregion

        #region constructeurs

        // NE PAS TOUCHER AU CONSTRUCTEUR (pour l'instant)
		public Journee(int nJour)
		{			
			NumJour = nJour;
			CompteRendu = "";
			this.ListActiviteJournee = new List<Activite>();
		}
        public Journee(int nJour, List<Spationaute> listeSpationaute)
        {
            CompteRendu = "";

            ListActiviteJournee = new List<Activite>();

            Dates h0 = new Dates(nJour, 0, 0);
            Dates h7 = new Dates(nJour, 7, 0);
            Dates h8 = new Dates(nJour, 8, 0);
            Dates h12 = new Dates(nJour, 12, 0);
            Dates h14 = new Dates(nJour, 14, 0);
            Dates h19 = new Dates(nJour, 19, 0);
            Dates h21 = new Dates(nJour, 21, 0);
            Dates h23 = new Dates(nJour, 23, 0);
            Dates h24_40 = new Dates(nJour, 24, 40);

            Coordonnees baseMission = new Coordonnees("base", new Point(0,0));
            string sleeping = "Sleeping";
            string eating = "Eating";
            string prive = "Private";

            //on ajoute les activites par defaut de la journee.

            ListActiviteJournee.Add(new Activite(sleeping, h0, h7, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(eating, h7, h8, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(prive, h8, h12, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(eating, h12, h14, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(prive, h14, h19, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(eating, h19, h21, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(prive, h21, h23, baseMission, CompteRendu, listeSpationaute));
            ListActiviteJournee.Add(new Activite(sleeping, h23, h24_40, baseMission, CompteRendu, listeSpationaute));
        }

        #endregion

        #region methodes
        public List<Activite> checkActivite(Activite newActivite)
        //on verifie si une activite empiète sur d'autres.
        {
            List<Activite> lst_ActiviteConflit = new List<Activite>();
            foreach (Activite activite in ListActiviteJournee)
            {
                if (activite.HeureFin.Heure>=newActivite.HeureDebut.Heure && activite.HeureFin.Minute>=newActivite.HeureDebut.Minute)
                {
                    foreach (Spationaute spatioOccupe in activite.ListSpationaute)
                    {
                        foreach (Spationaute spatioNewActivite in newActivite.ListSpationaute)
                        {
                            if (spatioNewActivite==spatioOccupe)
                            {
                                lst_ActiviteConflit.Add(activite);
                            }


                        }
                    }
                }
            }
            return lst_ActiviteConflit;
        }
		public void rechercheNomActivite(string mot, Dates dateDeb, Dates dateFin)
		{
			List<Activite> listPeriode = selectionPeriode(dateDeb, dateFin);
			List<Activite> listResult = listPeriode.FindAll(
			delegate(Activite act)
			{
				return (act.Nom == mot);
			}
			);
		}
		public void rechercheDescActivite(string mot, Dates dateDeb, Dates dateFin)
		{
			List<Activite> listPeriode = selectionPeriode(dateDeb, dateFin);
			List<Activite> listResult = listPeriode.FindAll(
			delegate(Activite act)
			{
				return (act.Descritpion.Contains(mot));
			}
			);
		}


		public List<Activite> selectionPeriode(Dates HeureDeb, Dates HeureFin)
		{
			List<Activite> lst_periode = new List<Activite>();
			foreach (Activite uneActivite in ListActiviteJournee)
			{
				if (uneActivite.HeureFin.Heure > HeureDeb.Heure || uneActivite.HeureDebut.Heure < HeureFin.Heure)
				{
					lst_periode.Add(uneActivite);
				}
			}
			return lst_periode;
		}


		public List<Activite> selectionPeriode(int HeureDeb, int HeureFin)
		{
			var datesDuree = this.int2Dates(HeureDeb, HeureFin);
			return selectionPeriode(datesDuree.Item1, datesDuree.Item2);
		}
		public List<Activite> rechercheLieuExploration(Point hg, Point bd, Dates HeureDeb, Dates HeureFin)
		// hg : point en haut à gauche du rectangle dans lequel on veut chercher
		// bd : point en bas à droite du rectangle dans lequel on veut chercher
		{
			List<Activite> listPeriode = selectionPeriode(HeureDeb, HeureFin);
			List<Activite> listResult = listPeriode.FindAll(
			delegate(Activite act)
			{
				return (act.Lieu.Position.X >= hg.X && act.Lieu.Position.X <= bd.X && act.Lieu.Position.Y <= hg.Y && act.Lieu.Position.Y >= bd.Y);
			}
			);
			return listResult;
		}
		public List<Activite> rechercheLieuExploration(Point hg, Point bd, int HeureDeb, int HeureFin)
		{
			var datesDuree = this.int2Dates(HeureDeb, HeureFin);
			return rechercheLieuExploration(hg, bd, datesDuree.Item1, datesDuree.Item2);
		}
        internal List<Activite> rechercheSorties(Dates HeureDeb, Dates HeureFin)
        {
            List<Activite> activitesDehors = new List<Activite>();
            foreach (Activite act in ListActiviteJournee)
            {
                if (act.Lieu.Position.X != 0 || act.Lieu.Position.Y != 0) activitesDehors.Add(act);
            }
            return activitesDehors;
        }
        internal List<Activite> rechercheSorties(int HeureDeb, int HeureFin)
        {
            var datesDuree = this.int2Dates(HeureDeb, HeureFin);
            return rechercheSorties(datesDuree.Item1, datesDuree.Item2);
        }
		private Tuple<Dates, Dates> int2Dates(int HeureDeb, int HeureFin)
        //converti 2 int en dates.
		{
			Dates dateDeb = new Dates(this.NumJour, HeureDeb, 0);
			Dates dateFin;
			if (HeureFin == 24) dateFin = new Dates(this.NumJour, HeureFin, 40);
			else dateFin = new Dates(this.NumJour, HeureFin, 0);
			return Tuple.Create(dateDeb, dateFin);
        }
        #endregion
    }
}
