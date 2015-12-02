using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;


namespace PI_Mars_Mission_Control
{
    [XmlRoot("Calendrier")]
    public class Calendrier
    {


#region Accesseurs & Propriétés

                
        private DateTime _jourDebutMission;
        [XmlElement("JourDebutMission")]
        public DateTime JourDebutMission
        {
            get { return _jourDebutMission; }
            set { _jourDebutMission = value; }
        }


        private List<Journee> _listJournees;
        [XmlArray("ListeJournees")]
        public List<Journee> ListJournees
        {
            get { return _listJournees; }
            set { _listJournees = value; }
        }    


        private List<Spationaute> _listSpationaute;
        [XmlArray("ListSpationaute")]
        public List<Spationaute> ListSpationaute
        {
            get { return _listSpationaute; }
            set { _listSpationaute = value; }
        }

        private List<Activite> _listActivite;
        [XmlArray("ListActivite")]
        public List<Activite> ListActivite
        {
            get { return _listActivite; }
            set { _listActivite = value; }
        }


#endregion


        public Calendrier()
        {
            this.ListJournees = new List<Journee>();
            this.ListActivite = new List<Activite>();
            this.ListSpationaute = new List<Spationaute>();
        }



#region méthodes


        public List<Journee> selectionPeriode(int jourDeb, int jourFin)
        /* jourDeb, jourFin : numéro des JOURS, et pas les INDICES, correspondant aux extremités de la période
         * renvoie une liste contenant tous les jours de la période demandée.*/
        {
            if (jourFin < jourDeb) throw new System.RankException("le jour de debut doit être plus petit que le jour de fin");
            List<Journee> list_periode=new List<Journee>();
            for (int i = jourDeb - 1; i <= jourFin - 1; i++)
            {
                list_periode.Add(ListJournees[i]);
            }
            return list_periode;
        }

		public List<Journee> extraireJourSortie()
		{
			throw new System.NotImplementedException();
		}

		public Dates conversionHeureMartienne(DateTime HeureTerre)
		{
            TimeSpan DureeMissionT = HeureTerre - JourDebutMission;
            int DureeMissionMin = (DureeMissionT.Days * 24 + DureeMissionT.Hours) * 60 + DureeMissionT.Minutes;
            int minuteM=DureeMissionMin%(60*24);
            int heureM=DureeMissionMin%60;
            int joursM=DureeMissionMin/(24*60);
            Dates DateM = new Dates(joursM, heureM, minuteM);
            return DateM;
        }

        public List<Activite> rechercheLieuExploration(Point hg, Point bd, int jourdeb, int jourfin)
        {
            List<Journee> listPeriode = selectionPeriode(jourdeb, jourfin);
            List<Activite> listResult = new List<Activite>();
            foreach (Journee uneJournee in listPeriode)
            {
                listResult.AddRange(uneJournee.rechercheLieuExploration(hg, bd, 0, 0));
            }
            return listResult;
        }
        public List<Activite> rechercheLieuExploration(Point hg, Point bd, Dates jourdeb, Dates jourfin)
        {
            List<Journee> listPeriode = selectionPeriode(jourdeb.jour, jourfin.jour);
            List<Activite> listResult = new List<Activite>();
            foreach (Journee uneJournee in listPeriode)
            {
                listResult.AddRange(uneJournee.rechercheLieuExploration(hg, bd, 0, 0));
            }
            return listResult;
        }


#endregion


    }
}
