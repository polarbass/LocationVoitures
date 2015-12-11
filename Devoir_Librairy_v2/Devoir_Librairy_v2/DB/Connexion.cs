using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Devoir_Librairy_v2.DB
{
    public class Connexion
    {
        string connetionString = null;
        public OleDbConnection cnn { get; set; }

        public Connexion()
        {
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/bruno/Documents/GitHubVisualStudio/LocationVoitures/Devoir_Librairy_v2/Devoir_Librairy_v2/App_Data/Librairie.mdb;";
            cnn = new OleDbConnection(connetionString);
        }

        public void Open()
        {
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }

        }

        public void Close()
        {
            try
            {
                cnn.Close();
                Console.WriteLine("Connection Closed ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not close the connection ! " + ex.Message);
            }
        }

        public DbCommand CreateCommand()
        {
            return cnn.CreateCommand();
        }

    }
}