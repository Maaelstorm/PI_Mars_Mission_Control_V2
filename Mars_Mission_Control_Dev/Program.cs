using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;

using System.Drawing;

namespace Mars_Mission_Control_Dev
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


			// Régions par personne pour tester des fonctionnalitées
			// PENSEZ à commenter l'intérieur des région avant de commit ! Thanks !!!

#region ANTOINE

            

#endregion


#region FLORIE-ANNE





#endregion


#region SAM


			// Application.Run(new TestSam());


#endregion

		}
    }
}
