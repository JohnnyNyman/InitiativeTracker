using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        public static bool OpenFormOnClose { get; set; }
 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            


            //Initialize the database connections
            InitiativeTrackerLibrary.GlobalConfig.InitializeConnections(InitiativeTrackerLibrary.DataBaseType.TextFile);
            Application.Run(new CharacterListForm());

        }
    }
}
