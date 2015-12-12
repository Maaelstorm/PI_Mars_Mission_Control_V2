﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;


// ANTOINE
namespace Mars_Mission_Control_Dev
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


        private int _jourActuel;
        [XmlElement("JourActuel")]
        public int JourActuel
        {
            get { return _jourActuel; }
            set { _jourActuel = value; }
        }


        private Carte _map;
        [XmlElement("Carte")]
        public Carte Map
        {
            get { return _map; }
            set { _map = value; }
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

        private List<Activite> _listActiviteDefaut;
        [XmlArray("ListeActiviteeDefaut")]
        public List<Activite> ListActiviteDefaut
        {
            get { return _listActiviteDefaut; }
            set { _listActiviteDefaut = value; }
        }


        #endregion

        #region constructeurs

        public Calendrier()
        {
            this.Map = null;
            this.ListJournees = new List<Journee>();
            this.ListActiviteDefaut = new List<Activite>();
            this.ListSpationaute = new List<Spationaute>();
        }
        public Calendrier(List<Journee> listeJournees, List<Spationaute> listeSpationautes)
        {
            this.Map = null;
            this.ListJournees = listeJournees;
            //this.ListActiviteDefaut = listeActivites;
            this.ListSpationaute = listeSpationautes;
        }
        public Calendrier(Carte map, List<Journee> listeJournees, List<Spationaute> listeSpationautes)
        {
            this.Map = map;
            this.ListJournees = listeJournees;
            //this.ListActiviteDefaut = listeActivites;
            this.ListSpationaute = listeSpationautes;
        }
        #endregion

        #region	Méthodes

        public void enregistrer()
        {
            DialogResult result = new DialogResult();

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Calendrier));

                // Ouverture de l'instance d'écriture en précisant le chemin du fichier
                using (TextWriter writer = new StreamWriter("./..//..//Calendrier.xml"))
                {
                    xs.Serialize(writer, this);
                }
                result = MessageBox.Show("Calendrier enregistré");
            }
            catch (Exception)
            {
                result = MessageBox.Show("Erreur lors de l'enregistrement");
                throw;
            }
        }


        public List<Activite> checkActivite(Activite newActivite)
        //on verifie si une activite empiète sur d'autres. Renvoie une liste contenant toutes les activités posant conflit.
        {
            List<Activite> lst_ActiviteConflit = new List<Activite>();
            foreach (Journee uneJournee in ListJournees)
            {
                foreach (Activite uneActivite in uneJournee.ListActiviteJournee)
                {
                    if (uneActivite.HeureFin.Heure >= newActivite.HeureDebut.Heure && uneActivite.HeureFin.Minute >= newActivite.HeureDebut.Minute)
                    {
                        foreach (Spationaute spatioOccupe in uneActivite.ListSpationaute)
                        {
                            foreach (Spationaute spatioNewActivite in newActivite.ListSpationaute)
                            {
                                if (spatioNewActivite == spatioOccupe)
                                {
                                    lst_ActiviteConflit.Add(uneActivite);
                                }
                            }
                        }
                    }
                }
            }
            return lst_ActiviteConflit;
        }
        public List<Journee> rechercheJournee(string nomAct, string motDescAct, string motCompteRendu, Dates dateDeb, Dates dateFin)
        {
            List<Journee> ListPeriode = new List<Journee>();
            //on parcours toutes les journées et on ajoute celle qui correspondent aux critères de recherche.
            foreach (Journee uneJournee in ListJournees)
            {
                if ((uneJournee.NumJour > dateDeb.Jour || uneJournee.NumJour < dateFin.Jour) && uneJournee.CompteRendu.Contains(motCompteRendu) && uneJournee.recherche(motDescAct, nomAct))
                {
                    ListPeriode.Add(uneJournee);
                }
            }
            return ListPeriode;

        }
        public List<Activite> selectionPeriodeAct(Dates dateDeb, Dates dateFin)
        {
            List<Activite> lst_periode = new List<Activite>();
            foreach (Journee uneJournee in ListJournees)
            {
                foreach (Activite uneActivite in uneJournee.ListActiviteJournee)
                {
                    //on regarde si l'activite est dans l'intervalle de temps qui nous intéresse
                    if (uneActivite.HeureFin.diff(dateDeb) < 0 || uneActivite.HeureFin.diff(dateFin) > 0)
                    {
                        lst_periode.Add(uneActivite);
                    }
                }
            }
            return lst_periode;
        }
        public List<Activite> rechercheNomActivitePeriode(string mot, Dates dateDeb, Dates dateFin)
        {
            List<Activite> listPeriode = selectionPeriodeAct(dateDeb, dateFin);
            List<Activite> listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.Nom == mot);
            }
            );
            return listResult;
        }

        public List<Activite> rechercheDescActivitePeriode(string mot, Dates dateDeb, Dates dateFin)
        {
            List<Activite> listPeriode = selectionPeriodeAct(dateDeb, dateFin);
            List<Activite> listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.Descritpion.Contains(mot));
            }
            );
            return listResult;
        }




        public List<Journee> selectionPeriodeJour(Dates dateDeb, Dates dateFin)
        {
            List<Journee> lst_periode = new List<Journee>();
            foreach (Journee uneJournee in ListJournees)
            {
                if (uneJournee.NumJour > dateDeb.Jour || uneJournee.NumJour < dateFin.Jour)
                {
                    lst_periode.Add(uneJournee);
                }
            }
            return lst_periode;
        }

        public List<Journee> selectionPeriodeJour(int HeureDeb, int HeureFin)
        {
            var datesDuree = this.int2dates(HeureDeb, HeureFin);
            return selectionPeriodeJour(datesDuree.Item1, datesDuree.Item2);
        }


        public List<Activite> rechercheLieuExploration(Point hg, Point bd, Dates HeureDeb, Dates HeureFin)
        // hg : point en haut à gauche du rectangle dans lequel on veut chercher
        // bd : point en bas à droite du rectangle dans lequel on veut chercher
        {
            List<Activite> listPeriode = selectionPeriodeAct(HeureDeb, HeureFin);
            List<Activite> listResult = listPeriode.FindAll(
            delegate(Activite act)
            {
                return (act.Lieu.Position.X >= hg.X && act.Lieu.Position.X <= bd.X && act.Lieu.Position.Y <= hg.Y && act.Lieu.Position.Y >= bd.Y);
            }
            );
            return listResult;
        }


        public List<Activite> rechercheSorties(Dates dateDeb, Dates dateFin)
        {

            List<Activite> activitesDehors = new List<Activite>();
            List<Journee> listPeriode = selectionPeriodeJour(dateDeb, dateFin);
            List<Activite> listSortiesJour;
            foreach (Journee jour in listPeriode)
            {
                listSortiesJour = jour.rechercheSorties(dateDeb, dateFin);
                if (listSortiesJour.Count() != 0) activitesDehors.AddRange(listSortiesJour);
            }
            return activitesDehors;
        }


        /*public List<Activite> rechercheLieuExploration(Point hg, Point bd, int HeureDeb, int HeureFin)
        {
            var datesDuree = this.int2dates(HeureDeb, HeureFin);
            return rechercheLieuExploration(hg, bd, datesDuree.Item1, datesDuree.Item2);
        }
		 */

        private Tuple<Dates, Dates> int2dates(int HeureDeb, int HeureFin)
        //converti deux int en dates, en considér. Si l'Heure de fin vaut 24, la date convertie correspond à 24 h et 40 min. 
        //Cette fonction sert juste pour le confort de codage.
        {
            Dates dateDeb = new Dates(this.JourActuel, HeureDeb, 0);
            Dates dateFin;
            if (HeureFin == 24) dateFin = new Dates(this.JourActuel, HeureFin, 40);
            else dateFin = new Dates(this.JourActuel, HeureFin, 0);
            return Tuple.Create(dateDeb, dateFin);
        }


        public Dates conversionHeureMartienne(DateTime HeureTerre)
        {
            TimeSpan DureeMissionT = HeureTerre - JourDebutMission;
            int DureeMissionMin = (DureeMissionT.Days * 24 + DureeMissionT.Hours) * 60 + DureeMissionT.Minutes;
            int minuteM = DureeMissionMin % (60 * 24+40)%60;
            int heureM = DureeMissionMin % (60*24+40)/60;
            int joursM = DureeMissionMin / (24 * 60+40);
            Dates DateM = new Dates(joursM, heureM, minuteM);
            return DateM;
        }

        #endregion
    }
}
