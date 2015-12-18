using Mars_Mission_Control_Dev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mars_Mission_Control_Dev
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
            LeCalendrier = new Calendrier(listeJournee, listeSpationaute);
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
        public void rechercheLieuExplorationTest()
        {
            initialiseCalendrier();
            Point hg = new Point(0,60); 
            Point bd = new Point(50,30); 
            Dates dateDeb = new Dates(0);
            Dates dateFin = new Dates(3);
            List<Activite> expected = new List<Activite>();
            expected.Add(LeCalendrier.ListJournees[2].ListActiviteJournee[1]);
            List<Activite> actual;
            actual = LeCalendrier.rechercheLieuExploration(hg, bd, dateDeb, dateFin);
            //Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expected, actual);
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
            //Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
