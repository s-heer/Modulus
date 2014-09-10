using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modulus.Classes
{
    class clDBConnect
    {
        protected SqlConnection _SQLConn;

        /// <summary>
        /// Cunstructer of the clDBConnect class.
        /// </summary>
        public clDBConnect()
        {
            OpenSettingsFile();
        }

        /// <summary>
        /// Get property of the SQL Connection object.
        /// </summary>
        public SqlConnection Conn { get { return this._SQLConn; } }

        /// <summary>
        /// this method will get the connection string from the clConnString class and associate it to the SQL connection object.
        /// </summary>
        public void OpenSettingsFile()
        {
            if (Properties.Config.Default.Data_Source != "")
            {
                clConnString CnnStr = new Classes.clConnString(Properties.Config.Default.Data_Source, Properties.Config.Default.Initial_Catalog, Properties.Config.Default.User_ID, Properties.Config.Default.Password);
                this._SQLConn = new SqlConnection(CnnStr.CnnString);
            }
            else
            {
                Forms.frmSettings frmSettings = new Forms.frmSettings();
                frmSettings.ShowDialog();
            }
        }
    }
}
