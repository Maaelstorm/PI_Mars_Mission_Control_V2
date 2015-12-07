using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using System.Windows.Forms;


namespace Mars_Mission_Control_Dev
{
	class GestionXml
	{

		
					
		/// <summary>
        /// Permet de générer les fichiers XML
        /// </summary>
        public static void genererDocXML()
        {
			Form1 f1 = new Form1();

			List<Journee> listJournee = f1.Cal.ListJournees;
			List<Activite> listActivite = f1.Cal.ListActivite;
			List<Spationaute> listSpationaute = f1.Cal.ListSpationaute;

			int nbElements = listSpationaute.Count;

			
           
            XmlDocument xmlDoc = new XmlDocument();
            XmlDocument xmlDocActs = new XmlDocument();

            XmlNode donnees = xmlDoc.CreateElement("Donnees");
            xmlDoc.AppendChild(donnees);

            XmlNode acts = xmlDocActs.CreateElement("Activites");
            xmlDocActs.AppendChild(acts);

            XmlNode debutMission = xmlDoc.CreateElement("DebutMission");
            donnees.AppendChild(debutMission);

            XmlNode jour = xmlDoc.CreateElement("Jour");
            XmlNode mois = xmlDoc.CreateElement("Mois");
            XmlNode annee = xmlDoc.CreateElement("Annee");
            XmlNode heures = xmlDoc.CreateElement("Heures");
            XmlNode minutes = xmlDoc.CreateElement("Minutes");
            XmlNode secondes = xmlDoc.CreateElement("Secondes");

            debutMission.AppendChild(jour);
            debutMission.AppendChild(mois);
            debutMission.AppendChild(annee);
            debutMission.AppendChild(heures);
            debutMission.AppendChild(minutes);
            debutMission.AppendChild(secondes);

            jour.InnerText = this.debutMission.Day.ToString();
            mois.InnerText = this.debutMission.Month.ToString();
            annee.InnerText = this.debutMission.Year.ToString();
            heures.InnerText = this.debutMission.Hour.ToString();
            minutes.InnerText = this.debutMission.Minute.ToString();
            secondes.InnerText = this.debutMission.Second.ToString();

            XmlNode nbE = xmlDoc.CreateElement("NbElements");
            donnees.AppendChild(nbE);
            nbE.InnerText = nbElements.ToString();

            XmlNode astronautes = xmlDoc.CreateElement("Astronautes");
            donnees.AppendChild(astronautes);
           
            foreach (Astronaute a in this.astronautes)
            {
                XmlNode astronaute = xmlDoc.CreateElement("Astronaute");
                astronautes.AppendChild(astronaute);
                a.genererXML(xmlDoc, xmlDocActs, astronaute, acts);
            }

            if (!System.IO.Directory.Exists("Donnees"))
                System.IO.Directory.CreateDirectory("Donnees");

            XmlDocument xmlDocDom = new XmlDocument();
            XmlNode domaines = xmlDocDom.CreateElement("Domaines");
            xmlDocDom.AppendChild(domaines);

            foreach (Domaine d in CalendrierMission.domaines)
            {
                XmlNode domaine = xmlDocDom.CreateElement("Domaine");
                domaines.AppendChild(domaine);

                XmlNode nomD = xmlDocDom.CreateElement("NomDom");
                domaine.AppendChild(nomD);
                nomD.InnerText = d.getNom();

                XmlNode couleur = xmlDocDom.CreateElement("Couleur");
                domaine.AppendChild(couleur);

                XmlNode r = xmlDocDom.CreateElement("R");
                couleur.AppendChild(r);
                r.InnerText = d.getCouleur()[0].ToString();

                XmlNode g = xmlDocDom.CreateElement("G");
                couleur.AppendChild(g);
                g.InnerText = d.getCouleur()[1].ToString();

                XmlNode b = xmlDocDom.CreateElement("B");
                couleur.AppendChild(b);
                b.InnerText = d.getCouleur()[2].ToString();

                XmlNode typeActivite = xmlDocDom.CreateElement("TypeActivite");
                domaine.AppendChild(typeActivite);

                foreach (TypeActivite ta in d.getActivites())
                {
                    XmlNode nomType = xmlDocDom.CreateElement("NomTA");
                    typeActivite.AppendChild(nomType);
                    nomType.InnerText = ta.getNom();
                }
            }

            xmlDocDom.Save("Donnees/Domaines.xml");
            xmlDoc.Save("Donnees/Mars-o-Matic_" + this.debutMission.Day + "_" + this.debutMission.Month + "_" + this.debutMission.Year + ".xml");
            xmlDocActs.Save("Donnees/ActivitesRefs_" + this.debutMission.Day + "_" + this.debutMission.Month + "_" + this.debutMission.Year + ".xml");
        }

        /// <summary>
        /// Permet d'initialiser les domaines en les chargeant depuis un fichier XML
        /// </summary>
		// DOMAINE = ACTIVITE
        public void initialiserDomaines()
        {
			Form1 f1 = new Form1();

			List<Journee> listJournee = f1.Cal.ListJournees;
			List<Activite> listActivite = f1.Cal.ListActivite;
			List<Spationaute> listSpationaute = f1.Cal.ListSpationaute;

            XmlDocument xmlDoc = new XmlDocument();

            try
            {
				xmlDoc.Load("./..//..//InfoGenerales.xml");
            }
            catch
            {
                string message = "Aucun fichier de sauvegarde n'a été trouvé.";
                MessageBox.Show(message);
                //creationDomainesAutomatique();
                return;
            }

            XmlNodeList nodeListDomaines = xmlDoc.GetElementsByTagName("Domaine");

            foreach (XmlNode node in nodeListDomaines)
            {
                String nom = node.SelectSingleNode("NomDom").InnerText;
                String r = node.SelectSingleNode("Couleur").SelectSingleNode("R").InnerText;
                String g = node.SelectSingleNode("Couleur").SelectSingleNode("G").InnerText;
                String b = node.SelectSingleNode("Couleur").SelectSingleNode("B").InnerText;
                int[] couleur;

                try
                {
                    couleur = new int[] { int.Parse(r), int.Parse(g), int.Parse(b) };
                }
                catch
                {
                    couleur = new int[] { 0, 0, 0 };
                }

                Domaine d = new Domaine(nom, couleur);

                CalendrierMission.domaines.Add(d);

                XmlNodeList nodeListTA = node.SelectSingleNode("TypeActivite").SelectNodes("NomTA");

                foreach (XmlNode nnode in nodeListTA)
                    d.ajouterActivite(new TypeActivite(nnode.InnerText));
            }
        }

        /// <summary>
        /// Permet de charger les données depuis un fichier XML
        /// </summary>
        /// <param name="marsOMatic">Le fichier XML Mars-o-Matic</param>
        /// <param name="activitesRefs">Le fichier XML ActivitesRefs associé au fichier précédent</param>
        private static void chargerXml(String xmlInfosGénérales, String xmlCalendrierListe)
        {
			Form1 f1 = new Form1();

			List<Journee> listJournee = f1.Cal.ListJournees;
			List<Activite> listActivite = f1.Cal.ListActivite;
			List<Spationaute> listSpationaute = f1.Cal.ListSpationaute;

            XmlDocument infoG = new XmlDocument();
			infoG.Load(xmlInfosGénérales);
            XmlDocument calListe = new XmlDocument();
			calListe.Load(xmlCalendrierListe);

			// Création d'un dictionnaire d'activité
            Dictionary<int, Activite> activitesBase = new Dictionary<int, Activite>();

			int nbElements = int.Parse(infoG.SelectSingleNode("Donnees").SelectSingleNode("NbElements").InnerText);

            /* Chargement données des activités de base */
            XmlNodeList activites = calListe.GetElementsByTagName("Activite");

            foreach (XmlNode n in activites)
            {
                Activite a;

                int num = int.Parse(n.SelectSingleNode("Numero").InnerText);
                bool exterieure = bool.Parse(n.SelectSingleNode("Exterieure").InnerText);
                bool exploration = bool.Parse(n.SelectSingleNode("Exploration").InnerText);
                TypeActivite ta = new TypeActivite(n.SelectSingleNode("TypeActivite").SelectSingleNode("Nom").InnerText);

                if (exterieure)
                    if (exploration)
                        a = new ExplorationExterieure(ta, "", null, null, null, null);
                    else
                        a = new ExperienceExterieure(ta, "", null, null, null, null);
                else
                    a = new Activite(ta);

                activitesBase.Add(num, a);

            }

            /* Chargement données */
			//int jour = int.Parse(infoG.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Jour").InnerText);		
			//int heures = int.Parse(infoG.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Heures").InnerText);
			//int minutes = int.Parse(infoG.SelectSingleNode("Donnees").SelectSingleNode("DebutMission").SelectSingleNode("Minutes").InnerText);

			//f1.Cal.JourDebutMission = new Dates(jour, heures, minutes);

            //TimeMartien nb = TimeMartien.calculerJours(debutMission);
            //int numJour = nb.getJours() + 1;

			XmlNodeList astronautesNodes = infoG.GetElementsByTagName("Astronaute");

            foreach (XmlNode n in astronautesNodes)
            {
                String nom = n.SelectSingleNode("Nom").InnerText;
                String prenom = n.SelectSingleNode("Prenom").InnerText;
                
                Astronaute a = new Astronaute(nom, prenom, age);
               
                Dictionary<int, Journee> joursMission = new Dictionary<int, Journee>();
                a.setJourneesMission(joursMission);

                astronautes.Add(a);
                a.getJourneesMission().Clear();
                astroList.Items.Add(a); // Ajout dans la liste => interface

                XmlNodeList missionNode = n.SelectSingleNode("JourneesMission").SelectNodes("Journee");

                foreach (XmlNode nn in missionNode)
                {
                    int num = int.Parse(nn.SelectSingleNode("Numero").InnerText);
                    String etat = nn.SelectSingleNode("Etat").InnerText;
                    IEtat etatJournee = new Passe();

                    if (etat.Equals("EnCours"))
                        etatJournee = new EnCours();
                    else if (etat.Equals("Futur"))
                        etatJournee = new Futur();

                    String rapport = nn.SelectSingleNode("Rapport").InnerText;

                    Journee j = new Journee(num, rapport, etatJournee, false);
                    j.getActivites().Clear();
                    joursMission.Add(num, j);

                    XmlNodeList activitesNode = nn.SelectSingleNode("Activites").SelectNodes("Activite");

                    foreach (XmlNode nnn in activitesNode)
                    {
                        int numA = int.Parse(nnn.SelectSingleNode("Numero").InnerText);
                        String transport = nnn.SelectSingleNode("Transport").InnerText;
                        ITransport transportAct = null;

                        if (transport.Equals("Scaphandre"))
                            transportAct = new Scaphandre();
                        else if (transport.Equals("Vehicule"))
                            transportAct = new Vehicule();

                        String description = nnn.SelectSingleNode("Description").InnerText;
                        etat = nnn.SelectSingleNode("Etat").InnerText;
                        IEtat etatAct = new Passe();

                        if (etat.Equals("EnCours"))
                            etatAct = new EnCours();
                        else if (etat.Equals("Futur"))
                            etatAct = new Futur();

                        int mD = int.Parse(nnn.SelectSingleNode("HeureDebut").InnerText);

                        int mF = int.Parse(nnn.SelectSingleNode("HeureFin").InnerText);

                        String xy = nnn.SelectSingleNode("XY").InnerText;
                        int x = int.Parse(xy.Split(',')[0]);
                        int y = int.Parse(xy.Split(',')[1]);

                        Lieu l = new Lieu(x, y);

                        Activite aBase = activitesBase[numA];
                        Activite act;

                        if (aBase.isActiviteExterieure())
                            if (aBase.isExperience())
                                act = new ExperienceExterieure(aBase.getTypeActivite(), description, new TimeMartien(0, 0, mD, 0), new TimeMartien(0, 0, mF, 0), l);
                            else
                                act = new ExplorationExterieure(aBase.getTypeActivite(), description, new TimeMartien(0, 0, mD, 0), new TimeMartien(0, 0, mF, 0), l, transportAct);
                        else
                            act = new Activite(aBase.getTypeActivite(), description, new TimeMartien(0, 0, mD, 0), new TimeMartien(0, 0, mF, 0), l);
                       

                        act.setDescription(description);

                        act.setEtat(etatAct);

                        j.ajouterActivite(act);
						                 
                    }
                 
                }
            }
		}
	}
}
