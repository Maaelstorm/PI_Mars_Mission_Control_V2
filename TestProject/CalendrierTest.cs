using Mars_Mission_Control_Dev;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
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
        ///Test pour conversionHeureMartienne
        ///</summary>
        [TestMethod()]
        public void conversionHeureMartienneTest()
        {            
            Calendrier target = new Calendrier(); 
            target.JourDebutMission = new DateTime(2015, 12, 16, 18, 00, 00);

            DateTime HeureTerre = new DateTime(); 
            HeureTerre = new DateTime(2015, 12, 18, 18, 00, 00);

            // 2880 = durée mission sur Terre en minute (pour 2 jours)
            // 1480 = durée 1 jour sur Mars 
            // 2880 / 1480 = 1,94... jours
            // 2880 mod 1480 = 1400
            // 1400 / 60 = 23,33 heures
            // 1400 mod 60 = 20 minutes 
            Dates expected = new Dates(1, 23, 20);
            
            Dates actual = target.conversionHeureMartienne(HeureTerre);

            Assert.AreEqual(expected.Jour, actual.Jour);
            Assert.AreEqual(expected.Heure, actual.Heure);
            Assert.AreEqual(expected.Minute, actual.Minute);
            
            // La ligne du dessous (générée par défaut) fait échouer le code à chaque fois si non commentée
            // Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
