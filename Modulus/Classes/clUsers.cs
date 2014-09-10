using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.Classes
{
    class clUsers
    {
        private string _UserID;
        private string _UserPswrd;

        /// <summary>
        /// Cunstructer of the User class
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strUserPswrd"></param>
        public clUsers(string strUserName, string strUserPswrd)
        {
            this._UserID = strUserName;
            this._UserPswrd = strUserPswrd;
        }


        /// <summary>
        /// get and Set proerties of the User Name.
        /// </summary>
        public string UsrName
        {
            get { return this._UserID; }
            set { this._UserID = value; }
        }

        /// <summary>
        /// Get and Set Properties of the User Password.
        /// </summary>
        public string UsrPswd
        {
            get { return this._UserPswrd; }
            set { this._UserPswrd = value; }
        }
    }
}
