using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modulus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This allows you to connect to the sql server and validate the credentails entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text != "" && txtUsrPswrd.Password != "") 
            {
                try
                {
                    // Create a new instance of clSqlDataReader with a new instance of Query sent in paramter.
                    Classes.clSqlDataReader reader = new Classes.clSqlDataReader(new Classes.clQuery().GetCredentialsQuery(txtUserName.Text, txtUsrPswrd.Password));
                    reader.sqlReader.Read();

                    if (reader.sqlReader.HasRows)
                    {
                        Classes.clUsers user = new Classes.clUsers(reader.sqlReader["UserID"].ToString(), reader.sqlReader["Password"].ToString());
                        MessageBox.Show(user.UsrName + "  :  " + user.UsrPswd);
                    }
                    else
                    {
                        MessageBox.Show("The credentials that you have entered are not valid.");
                        this.txtUserName.Clear();
                        this.txtUsrPswrd.Clear();
                        this.txtUserName.Focus();
                    }

                    // Close the connection to SQL server.
                    reader.Conn.Close();
                }
                catch (Exception ex)
                {
                    new Classes.clErrorHandler(ex.Message, "btnLogin_Click").ShowMessage();
                }
            }
            else 
            {
                MessageBox.Show("Please enter a user name and password.");
            }
        }

        /// <summary>
        /// Create/Modify the connection string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuConnection_Click(object sender, RoutedEventArgs e)
        {
            Forms.frmSettings settings = new Forms.frmSettings();
            settings.ShowDialog();
        }
    }
}
