using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;

	
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

		// Constructeur 
		public Journee(int nJour, Form1 f1)
		{
			f1 = new Form1();

			CompteRendu = "";
			Dates h0 = new Dates(nJour, 0, 0);
			Dates h7 = new Dates(nJour, 7, 0);
			Dates h8 = new Dates(nJour, 8, 0);
			Dates h12 = new Dates(nJour, 12, 0);
			Dates h14 = new Dates(nJour, 14, 0);
			Dates h19 = new Dates(nJour, 19, 0);
			Dates h21 = new Dates(nJour, 21, 0);
			Dates h23 = new Dates(nJour, 23, 0);
			Dates h24_40 = new Dates(nJour, 24, 40);
									
			Coordonnees baseMission = new Coordonnees();
			string sleeping = "sleeping";
			string eating = "eating";
			string prive = "Prive";

			//on ajoute les activites par defaut de la journee.
			ListActiviteJournee.Add(new Activite(h0, h7, baseMission, sleeping, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h7, h8, baseMission, eating, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h8, h12, baseMission, prive, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h12, h14, baseMission, eating, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h14, h19, baseMission, prive, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h19, h21, baseMission, eating, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h21, h23, baseMission, prive, f1.Cal.ListSpationaute));
			ListActiviteJournee.Add(new Activite(h23, h24_40, baseMission, sleeping, f1.Cal.ListSpationaute));
		}

		public Journee(int index, List<Journee> listeJournee)
        {					
			NumJour = index;
            listeJournee.Add(this);
			// ListActiviteJournee = Activite
			CompteRendu = "";
        }
				  
		
		// Méthodes

		public void serializer()
		{
			XmlSerializer xs = new XmlSerializer(typeof(Journee));
			// Ouverture de l'instance d'écriture en précisant le chemin du fichier
			using (TextWriter writer = new StreamWriter("./..//..//InfoGenerales.xml"))
			{
				xs.Serialize(writer, this);
			}

			Console.WriteLine(string.Format("Journee : enregistrement réussi"));
		}


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

       
		public void rechercheJourActivite(string mot)
		{
			/*for (int i=0;i<.i]();i++)
			{
				if (mot==lst_ActiviteJournee[]
			} il doit y avoir un truc déjà fait pour rechercher*/
		}


		public List<Activite> selectionPeriode(int heureDeb, int heureFin)
		{
			List<Activite> lst_periode = new List<Activite>();
			foreach (Activite uneActivite in ListActiviteJournee)
			{
				if (uneActivite.HeureFin.heure > heureDeb || uneActivite.HeureDebut.heure < heureFin)
				{
					lst_periode.Add(uneActivite);
				}
			}
			return lst_periode;
		}
        public List<Activite> rechercheLieuExploration(Point hg, Point bd, int heureDeb, int heureFin)
            // hg : point en haut à gauche du rectangle dans lequel on veut chercher
            // bd : point en bas à droite du rectangle dans lequel on veut chercher
        {
            List<Activite> listPeriode=selectionPeriode(heureDeb, heureFin);
            List<Activite>  listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.Lieu.Position.X>=hg.X && act.Lieu.Position.X<=bd.X && act.Lieu.Position.Y<=hg.Y && act.Lieu.Position.Y>=bd.Y);
            }
            );
            return listResult;
        }
		        
    }
}
