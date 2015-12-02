using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_Mars_Mission_Control
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
                if (value >= 0 && value<=24) _heure = value;
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
                else throw new System.ArgumentException("la valeur de la minute doit être comprise entre 0 et 24 inclus");
            }
        }
        
        #endregion
        #region constructeurs
        public Dates()
        {
            Jour = 0;
            Heure = 0;
            Minute = 0;
        }
        public Dates(int leJour):this()
        {
            Jour=leJour;
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
        public Dates ecart(Dates date)
        {
            int date1=(this.Jour*24+this.Heure)*60+this.Minute;
            int date2=(date.Jour*24+date.Heure)*60+date.Minute;
            int ecartMin = Math.Abs(date1 - date2);
            int ecartJour = ecartMin/(60*24);
            int ecartH = (ecartMin/60)%24;
            ecartMin = ecartMin%60;
            Dates ecartTps = new Dates(ecartJour, ecartH, ecartMin);
            return ecartTps;
        }
        #endregion
    }
}
