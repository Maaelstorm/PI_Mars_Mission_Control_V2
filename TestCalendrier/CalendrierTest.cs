using Mars_Mission_Control_Dev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PI_Mars_Mission_Control
{
    
    
    /// <summary>
    ///Classe de test pour CalendrierTest, destinée à contenir tous
    ///les tests unitaires CalendrierTest
    ///</summary>
    [TestClass()]
    public class CalendrierTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private Calendrier _leCalendrier;

        public Calendrier LeCalendrier
        {
            get { return _leCalendrier; }
            set { _leCalendrier = value; }
        }

        public void initialiseCalendrier()
        {
            List<Activite> listeActivite = new List<Activite>();
            List<Journee> listeJournee = new List<Journee>();
            List<Spationaute> listeSpationaute = new List<Spationaute>();
            listeSpationaute.Add(new Spationaute("bobby"));
            listeSpationaute.Add(new Spationaute("John"));
            listeSpationaute.Add(new Spationaute("William"));

            //on remplit les journees
            for (int i = 0; i < 20; i++)
            {
                listeJournee.Add(new Journee(i, listeSpationaute));
            }
            listeJournee[2].ListActiviteJournee[1].Lieu.Position = new Point(30, 40);
            listeJournee[5].ListActiviteJournee[3].Lieu.Position = new Point(20, 50);
            listeJournee[10].ListActiviteJournee[6].Lieu.Position = new Point(-15, 70);
            listeJournee[17].ListActiviteJournee[2].Lieu.Position = new Point(-60, -10);
            DateTime jourDebMission = new DateTime(2015, 11, 15);
            LeCalendrier = new Calendrier(listeJournee, listeActivite, listeSpationaute);
        }
        

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        //[TestMethod()]
        //public void selectionPeriodeActTest()
        //{
        //    initialiseCalendrier();
        //    Dates dateDeb = new Dates(5,12);
        //    Dates dateFin = new Dates(7,10);
        //    List<Activite> expected = new List<Activite>();
        //    foreach 
        //    List<Activite> actual;
        //    actual = LeCalendrier.selectionPeriodeAct(dateDeb, dateFin);
        //    Assert.AreEqual(expected, actual);
        //}

        ///// <summary>
        /////Test pour selectionPeriodeJour
        /////</summary>
        //[TestMethod()]
        //public void selectionPeriodeJourTest()
        //{
        //    Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
        //    Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
        //    Dates dateFin = null; // TODO: initialisez à une valeur appropriée
        //    List<Journee> expected = null; // TODO: initialisez à une valeur appropriée
        //    List<Journee> actual;
        //    actual = target.selectionPeriodeJour(dateDeb, dateFin);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        //}
        [TestMethod()]
        public void checkActiviteTest()
        {
            initialiseCalendrier();
            Activite newActivite = new Activite("eating", new Dates(5, 3), new Dates(5, 9), new Coordonnees("base", new Point(0, 0)), "toto", LeCalendrier.ListSpationaute); // TODO: initialisez à une valeur appropriée
            List<Activite> expected = new List<Activite>();
            expected.Add(LeCalendrier.ListJournees[5].ListActiviteJournee[0]);
            expected.Add(LeCalendrier.ListJournees[5].ListActiviteJournee[1]);
            expected.Add(LeCalendrier.ListJournees[5].ListActiviteJournee[2]);
            List<Activite> actual;
            actual = LeCalendrier.checkActivite(newActivite);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void conversionHeureMartienneTest()
        {
            //on créé un calendrier
            initialiseCalendrier();
            DateTime HeureTerre = new DateTime(2015, 12, 10); 
            Dates expected = new Dates(34,1,20);
            Dates actual;
            actual = LeCalendrier.conversionHeureMartienne(HeureTerre);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void rechercheDescActivitePeriodeTest()
        {
            initialiseCalendrier();
            string mot = "pigeon";
            Dates dateDeb = new Dates(18, 12, 1);
            Dates dateFin = new Dates(22, 0, 0);
            Activite Act20_4=LeCalendrier.ListJournees[20].ListActiviteJournee[4];
            Activite Act21_0=LeCalendrier.ListJournees[21].ListActiviteJournee[0];
            Activite Act22_0=LeCalendrier.ListJournees[22].ListActiviteJournee[0];
            Act20_4.Descritpion = "le texte a trouver pigeon est ici";
            Act21_0.Descritpion = "le texte a ne pas trouver est ici";
            Act22_0.Descritpion = "le texte a ne pas trouver pigeon est ici";
            List<Activite> expected = new List<Activite>();
            expected.Add(Act20_4);
            List<Activite> actual;
            actual = LeCalendrier.rechercheDescActivitePeriode(mot, dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void rechercheLieuExplorationTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            Point hg = new Point(); // TODO: initialisez à une valeur appropriée
            Point bd = new Point(); // TODO: initialisez à une valeur appropriée
            Dates HeureDeb = null; // TODO: initialisez à une valeur appropriée
            Dates HeureFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheLieuExploration(hg, bd, HeureDeb, HeureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheNomActivitePeriode
        ///</summary>
        [TestMethod()]
        public void rechercheNomActivitePeriodeTest()
        {
            initialiseCalendrier();
            string mot = "sleeping"; 
            Dates dateDeb = new Dates(10,2,0); 
            Dates dateFin = new Dates(12, 2, 0);
            List<Activite> expected = new List<Activite>();
            for (int i = 10; i <= 12; i++)
            {
                expected.Add(LeCalendrier.ListJournees[i].ListActiviteJournee[0]);
                expected.Add(LeCalendrier.ListJournees[i].ListActiviteJournee[7]);
            }
            List<Activite> actual;
            actual = LeCalendrier.rechercheNomActivitePeriode(mot, dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void rechercheSortiesTest()
        {
            initialiseCalendrier();
            Dates dateDeb = new Dates();
            Dates dateFin = new Dates(7);
            List<Activite> expected = new List<Activite>();
            expected.Add(LeCalendrier.ListJournees[2].ListActiviteJournee[1]);
            expected.Add(LeCalendrier.ListJournees[5].ListActiviteJournee[3]);
            List<Activite> actual;
            actual = LeCalendrier.rechercheSorties(dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
        }
    }
}
