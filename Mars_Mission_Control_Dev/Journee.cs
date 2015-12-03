using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;


// ANTOINE	
namespace PI_Mars_Mission_Control
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

 
		// NE PAS TOUCHER AU CONSTRUCTEUR (pour l'instant)
		public Journee(int nJour)
		{			
			NumJour = nJour;
			CompteRendu = "";
			this.ListActiviteJournee = new List<Activite>();
		}




        #region methodes
        public List<Activite> checkActivite(Activite newActivite)
        //on verifie si une activite empiète sur d'autres.
        {
            List<Activite> lst_ActiviteConflit = new List<Activite>();
            foreach (Activite activite in ListActiviteJournee)
            {
                if (activite.HeureFin.heure>=newActivite.HeureDebut.heure && activite.HeureFin.minute>=newActivite.HeureDebut.minute)
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
		public void rechercheTexteActivite(string mot, Dates dateDeb, Dates dateFin)
		{
			List<Activite> listPeriode = selectionPeriode(dateDeb, dateFin);
			List<Activite> listResult = listPeriode.FindAll(
			delegate(Activite act)
			{
				return (act.Descritpion.Contains(mot));
			}
			);
		}


		public List<Activite> selectionPeriode(Dates heureDeb, Dates heureFin)
		{
			List<Activite> lst_periode = new List<Activite>();
			foreach (Activite uneActivite in ListActiviteJournee)
			{
				if (uneActivite.HeureFin.heure > heureDeb.heure || uneActivite.HeureDebut.heure < heureFin.heure)
				{
					lst_periode.Add(uneActivite);
				}
			}
			return lst_periode;
		}


		public List<Activite> selectionPeriode(int heureDeb, int heureFin)
		{
			var datesDuree = this.duree(heureDeb, heureFin);
			return selectionPeriode(datesDuree.Item1, datesDuree.Item2);
		}
		public List<Activite> rechercheLieuExploration(Point hg, Point bd, Dates heureDeb, Dates heureFin)
		// hg : point en haut à gauche du rectangle dans lequel on veut chercher
		// bd : point en bas à droite du rectangle dans lequel on veut chercher
		{
			List<Activite> listPeriode = selectionPeriode(heureDeb, heureFin);
			List<Activite> listResult = listPeriode.FindAll(
			delegate(Activite act)
			{
				return (act.Lieu.Position.X >= hg.X && act.Lieu.Position.X <= bd.X && act.Lieu.Position.Y <= hg.Y && act.Lieu.Position.Y >= bd.Y);
			}
			);
			return listResult;
		}
		public List<Activite> rechercheLieuExploration(Point hg, Point bd, int heureDeb, int heureFin)
		{
			var datesDuree = this.duree(heureDeb, heureFin);
			return rechercheLieuExploration(hg, bd, datesDuree.Item1, datesDuree.Item2);
		}
		private Tuple<Dates, Dates> duree(int heureDeb, int heureFin)
		{
			Dates dateDeb = new Dates(this.NumJour, heureDeb, 0);
			Dates dateFin;
			if (heureFin == 24) dateFin = new Dates(this.NumJour, heureFin, 40);
			else dateFin = new Dates(this.NumJour, heureFin, 0);
			return Tuple.Create(dateDeb, dateFin);
        }
        #endregion
    }
}
