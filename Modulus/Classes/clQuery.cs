using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.Classes
{
    class clQuery
    {
        /// <summary>
        /// This method will build and return the query to check the user's credentials.
        /// </summary>
        /// <param name="UsrID"></param>
        /// <param name="UsrPswrd"></param>
        /// <returns></returns>
        public string GetCredentialsQuery(string UsrID, string UsrPswrd) 
        {
            string MyQuery;

            MyQuery = "SELECT * " +
                      "FROM Users " +
                      "WHERE UserID = '" + UsrID + "' AND Password = '" + UsrPswrd + "'";

            return MyQuery;
        }
    }
}
