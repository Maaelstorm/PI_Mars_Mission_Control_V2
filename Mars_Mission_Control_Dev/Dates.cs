﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars_Mission_Control_Dev
{
    public class Dates
    {
        #region Accesseurs & propriétés
        private int _jour;
        public int Jour
        {
            get { return _jour; }
            set
            {
                if (value >= 0 && value <= 500) _jour = value;
                else throw new System.ArgumentException("le numero du jour doit être compris entre 0 et 500 inclus");
            }
        }

        private int _heure;
        public int Heure
        {
            get { return _heure; }
            set
            {
                if (value >= 0 && value <= 24) _heure = value;
                else throw new System.ArgumentException("la valeur de l'heure doit être comprise entre 0 et 24 inclus");
            }
        }
        
        private int _minute;
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value >= 0 && value <= 60) _minute = value;
                else throw new System.ArgumentException("la valeur de la minute doit être comprise entre 0 et 60 inclus");
            }
        }

        #endregion
        #region constructeurs
        public Dates()
        {            
        }
        public Dates(int leJour)
            : this()
        {
            Jour = leJour;
        }
        public Dates(int leJour, int lheure)
            : this(leJour)
        {
            Heure = lheure;
        }
        public Dates(int leJour, int lheure, int laMinute)
            : this(leJour, lheure)
        {
            Minute = laMinute;
        }
        #endregion
        #region methodes
        public int diff(Dates date)
            /*retourne la différence en minutes entre la date this et la date passée en argument.
             * si la date en argument est posterieure à la date this, la valeur de retour est positive. 
             * Elle est négative sinon*/
        {
            int date1 = (this.Jour * 24 + this.Heure) * 60 + this.Minute;
            int date2 = (date.Jour * 24 + date.Heure) * 60 + date.Minute;
            int ecartMin = date2 - date1;
            return ecartMin;
        }
        public Dates ecart(Dates date)
        {
            int ecartMin = Math.Abs(diff(date));
            int ecartJour = ecartMin / (60 * 24);
            int ecartH = (ecartMin / 60) % 24;
            ecartMin = ecartMin % 60;
            Dates ecartTps = new Dates(ecartJour, ecartH, ecartMin);
            return ecartTps;
        }
        public override string ToString()
        {
            return String.Format("{0}:{1}", this.Heure, this.Minute);
        }
        #endregion
    }
}
