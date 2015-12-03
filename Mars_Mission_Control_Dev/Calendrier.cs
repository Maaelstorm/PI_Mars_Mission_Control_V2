using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;


// ANTOINE
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
        private uint _numJour;

        public uint NumJour
        {
            get { return _numJour; }
            set { _numJour = value; }
        }



#endregion

    #region constructeurs
        public Calendrier()
        {
            this.ListJournees = new List<Journee>();
            this.ListActivite = new List<Activite>();
            this.ListSpationaute = new List<Spationaute>();
        }
        public Calendrier(List<Journee> listeJournees, List<Activite> listeActivites, List<Spationaute> listeSpationautes)
        {
            ListJournees = listeJournees;
            ListActivite = listeActivites;
            ListSpationaute = listeSpationautes;
        }
        #endregion

    #region	Méthodes

        public List<Activite> checkActivite(Activite newActivite)
        //on verifie si une activite empiète sur d'autres. Renvoie une liste contenant toutes les activités posant conflit.
        {
            List<Activite> lst_ActiviteConflit = new List<Activite>();
            foreach (Activite activite in ListActivite)
            {
                if (activite.HeureFin.heure >= newActivite.HeureDebut.heure && activite.HeureFin.minute >= newActivite.HeureDebut.minute)
                {
                    foreach (Spationaute spatioOccupe in activite.ListSpationaute)
                    {
                        foreach (Spationaute spatioNewActivite in newActivite.ListSpationaute)
                        {
                            if (spatioNewActivite == spatioOccupe)
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
            foreach (Activite uneActivite in ListActivite)
            {
                if (uneActivite.HeureFin.heure > heureDeb.heure || uneActivite.HeureDebut.heure < heureFin.heure)
                {
                    lst_periode.Add(uneActivite);
                }
            }
            return lst_periode;
        }

        //public List<Activite> selectionPeriode(int heureDeb, int heureFin)
        //{
        //    var datesDuree = this.int2dates(heureDeb, heureFin);
        //    return selectionPeriode(datesDuree.Item1, datesDuree.Item2);
        //}
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
        //public List<Activite> rechercheLieuExploration(Point hg, Point bd, int heureDeb, int heureFin)
        //{
        //    var datesDuree = this.int2dates(heureDeb, heureFin);
        //    return rechercheLieuExploration(hg, bd, datesDuree.Item1, datesDuree.Item2);
        //}
        //private Tuple<Dates, Dates> int2dates(int heureDeb, int heureFin)
        ////converti deux int en dates, en considér. Si l'heure de fin vaut 24, la date convertie correspond à 24 h et 40 min. 
        ////Cette fonction sert juste pour le confort de codage.
        //{
        //    Dates dateDeb = new Dates(this.NumJour, heureDeb, 0);
        //    Dates dateFin;
        //    if (heureFin == 24) dateFin = new Dates(this.NumJour, heureFin, 40);
        //    else dateFin = new Dates(this.NumJour, heureFin, 0);
        //    return Tuple.Create(dateDeb, dateFin);
        //}
        #endregion
    }
}
