using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace InitiativeTrackerLibrary
{
    public static class GlobalConfig
    {
        //This is a list of anything that impliments the Interface of IDataConnection.
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(DataBaseType db)
        {
            if (db == DataBaseType.TextFile)
            {
                // TODO Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
