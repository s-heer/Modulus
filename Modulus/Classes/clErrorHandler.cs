using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Modulus.Classes
{
    class clErrorHandler
    {
        private string _message;
        private string _method;

        /// <summary>
        /// Cunstructer of the Error Handler.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="meth"></param>
        public clErrorHandler(string msg, string meth)
        {
            this._message = msg;
            this._method = meth;
        }

        /// <summary>
        /// Get and Set properties of the Message.
        /// </summary>
        public string msg
        {
            get { return this._message; }
            set { this._message = value; }
        }

        /// <summary>
        /// get and Set properties of the Method.
        /// </summary>
        public string meth
        {
            get { return this._method; }
            set { this._method = value; }
        }

        /// <summary>
        /// This method will build the Error Message String and show it to the user.
        /// </summary>
        public void ShowMessage()
        {
            string strMsg;

            // Build the string for the method that contains the error.
            strMsg = this.msg + "\nError In Method : " + this.meth;
            MessageBox.Show(strMsg);
        }
    }
}
