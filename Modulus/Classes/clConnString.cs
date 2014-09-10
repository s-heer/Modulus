using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.Classes
{
    class clConnString
    {
        private string _DataSource;
        private string _NameDB;
        private string _UserName;
        private string _UserPswrd;
        private string _ConnectionString;

        /// <summary>
        /// Cunstructer to create the SQL connection string.
        /// </summary>
        /// <param name="strDataSource"></param>
        /// <param name="strNameDB"></param>
        /// <param name="strUserName"></param>
        /// <param name="strUserPswrd"></param>
        public clConnString(string strDataSource, string strNameDB, string strUserName, string strUserPswrd)
        {
            this._DataSource = strDataSource;
            this._NameDB = strNameDB;
            this._UserName = strUserName;
            this._UserPswrd = strUserPswrd;
        }

        /// <summary>
        /// Get and Set of the Data source
        /// </summary>
        public string DataSource
        {
            get { return this._DataSource; }
            set { this._DataSource = value; }
        }

        /// <summary>
        /// Get and Set of the Database Name.
        /// </summary>
        public string DBName
        {
            get { return this._NameDB; }
            set { this._NameDB = value; }
        }

        /// <summary>
        /// Get and Set of the SQL User Name.
        /// </summary>
        public string Usr
        {
            get { return this._UserName; }
            set { this._UserName = value; }
        }

        /// <summary>
        /// Get and Set of the SQL User Password.
        /// </summary>
        public string Pswd
        {
            get { return this._UserPswrd; }
            set { this._UserPswrd = value; }
        }

        /// <summary>
        /// Get of the SQL connection string built.
        /// </summary>
        public string CnnString
        {
            get { return GetConnectionString(); }
        }

        /// <summary>
        /// This method will build and return the SQL connection string.
        /// </summary>
        /// <returns></returns>
        private string GetConnectionString()
        {
            string strBuildCnnString;

            strBuildCnnString = "Data Source=" + this._DataSource + ";" +
                                "Initial Catalog=" + this._NameDB + ";" +
                                "User ID=" + this._UserName + ";" +
                                "Password=" + this._UserPswrd + ";" +
                                "Connect Timeout=15;";
            
            return strBuildCnnString;
        }
    }
}
