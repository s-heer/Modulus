using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modulus.Classes
{
    class clSqlCommand : Classes.clDBConnect
    {
        protected SqlCommand _SQLCommand;

        /// <summary>
        /// Cunstructer of the clSqlCommand class, build the Sqlcommand.
        /// </summary>
        /// <param name="MyQuery"></param>
        public clSqlCommand(string MyQuery)
        {
            try
            {
                this._SQLCommand = new SqlCommand(MyQuery, this.Conn);
            }
            catch (Exception ex)
            {
                new Classes.clErrorHandler(ex.Message, "clSqlCommand").ShowMessage();
            }
        }

        /// <summary>
        /// Get property of the _SQLCommand.
        /// </summary>
        public SqlCommand sqlCmd 
        { 
            get { return this._SQLCommand; }
        }
    }
}
