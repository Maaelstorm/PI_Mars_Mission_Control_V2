using Mars_Mission_Control_Dev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TestCalendrier
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


        /// <summary>
        ///Test pour checkActivite
        ///</summary>
        [TestMethod()]
        public void checkActiviteTest(Calendrier cal)
        {
            Calendrier target = cal;
            Activite newActivite = new Activite("eating", new Dates(5, 3), new Dates(5, 9), new Coordonnees("base", new Point(0, 0)), "toto", cal.ListSpationaute); // TODO: initialisez à une valeur appropriée
            List<Activite> expected = new List<Activite>();
            expected.Add(cal.ListJournees[5].ListActiviteJournee[0]);
            expected.Add(cal.ListJournees[5].ListActiviteJournee[1]);
            expected.Add(cal.ListJournees[5].ListActiviteJournee[2]);
            List<Activite> actual;
            actual = target.checkActivite(newActivite);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test pour conversionHeureMartienne
        ///</summary>
        [TestMethod()]
        public void conversionHeureMartienneTest(Calendrier cal)
        {
            Calendrier target = cal; 
            DateTime HeureTerre = new DateTime(2015, 01, 10); // TODO: initialisez à une valeur appropriée
            Dates expected = new Dates(); // TODO: initialisez à une valeur appropriée
            Dates actual;
            actual = target.conversionHeureMartienne(HeureTerre);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour enregistrer
        ///</summary>
        [TestMethod()]
        public void enregistrerTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            target.enregistrer();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour rechercheDescActivitePeriode
        ///</summary>
        [TestMethod()]
        public void rechercheDescActivitePeriodeTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            string mot = string.Empty; // TODO: initialisez à une valeur appropriée
            Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
            Dates dateFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheDescActivitePeriode(mot, dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheLieuExploration
        ///</summary>
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
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            string mot = string.Empty; // TODO: initialisez à une valeur appropriée
            Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
            Dates dateFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheNomActivitePeriode(mot, dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour rechercheSorties
        ///</summary>
        [TestMethod()]
        public void rechercheSortiesTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
            Dates dateFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.rechercheSorties(dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour selectionPeriodeAct
        ///</summary>
        [TestMethod()]
        public void selectionPeriodeActTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            Dates HeureDeb = null; // TODO: initialisez à une valeur appropriée
            Dates HeureFin = null; // TODO: initialisez à une valeur appropriée
            List<Activite> expected = null; // TODO: initialisez à une valeur appropriée
            List<Activite> actual;
            actual = target.selectionPeriodeAct(HeureDeb, HeureFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour selectionPeriodeJour
        ///</summary>
        [TestMethod()]
        public void selectionPeriodeJourTest()
        {
            Calendrier target = new Calendrier(); // TODO: initialisez à une valeur appropriée
            Dates dateDeb = null; // TODO: initialisez à une valeur appropriée
            Dates dateFin = null; // TODO: initialisez à une valeur appropriée
            List<Journee> expected = null; // TODO: initialisez à une valeur appropriée
            List<Journee> actual;
            actual = target.selectionPeriodeJour(dateDeb, dateFin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
