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
		[XmlElement("NumJour")]
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
		
        // Constructeur par défaut dont le num jour est égal à 0 (pour pouvoir sérialiser l'objet journée)
		public Journee()
		{
			NumJour = 0;
			CompteRendu = "";
			this.ListActiviteJournee = new List<Activite>();
		}

		public Journee(int nJour)
		{			
			NumJour = nJour;
			CompteRendu = "";
			this.ListActiviteJournee = new List<Activite>();
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
