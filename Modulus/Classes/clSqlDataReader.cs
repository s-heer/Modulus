using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modulus.Classes
{
    class clSqlDataReader : Classes.clSqlCommand
    {
        private SqlDataReader _sqlDataReader;

        /// <summary>
        /// Cunstructer of the clSqlDatareader class.
        /// </summary>
        /// <param name="Query"></param>
        public clSqlDataReader(string Query) : base(Query)
        {
            try
            {
                this.Conn.Open();
                this._sqlDataReader = this.sqlCmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                new Classes.clErrorHandler("Query Error : " + e.Message, "clSqlDataReader").ShowMessage();
            }
            catch (Exception ex)
            {
                new Classes.clErrorHandler(ex.Message, "clSqlDataReader").ShowMessage();
            }
        }

        /// <summary>
        /// Get property of the _sqlDataReader.
        /// </summary>
        public SqlDataReader sqlReader { get { return this._sqlDataReader; } }
    }
}
