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
using System.Windows.Shapes;

namespace Modulus.Forms
{
    /// <summary>
    /// Interaction logic for frmSettings.xaml
    /// </summary>
    public partial class frmSettings : Window
    {
        public frmSettings()
        {
            InitializeComponent();
            LoadSettings();
            IsFormEnabled(false);
        }
           
        /// <summary>
        /// This method allows you to show the information that is in Config.Settings file
        /// </summary>
        public void LoadSettings()
        {
            txtServerName.Text = Properties.Config.Default.Data_Source;
            txtDBName.Text = Properties.Config.Default.Initial_Catalog;
            txtUserID.Text = Properties.Config.Default.User_ID;
            txtPassword.Password = Properties.Config.Default.Password;
        }

        /// <summary>
        /// Event handler for the btnExit, allows to close the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for the btnSave, allows to save the changes into the Config.Settings file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Properties.Config.Default.Data_Source = txtServerName.Text;
            Properties.Config.Default.Initial_Catalog = txtDBName.Text;
            Properties.Config.Default.User_ID = txtUserID.Text;
            Properties.Config.Default.Password = txtPassword.Password;

            Properties.Config.Default.Save();

            MessageBox.Show("The changes have been saved!", "Saved");
        }

        /// <summary>
        /// Event Handler of the button Edit, Call method so we can modify the connection string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            IsFormEnabled(true);
        }

        /// <summary>
        /// Function to enable or not the fields to modify the connection string to the SQL server.
        /// </summary>
        /// <param name="IsEnabled"></param>
        private void IsFormEnabled(Boolean IsEnabled)
        {
            this.txtServerName.IsEnabled = IsEnabled;
            this.txtDBName.IsEnabled = IsEnabled;
            this.txtUserID.IsEnabled = IsEnabled;
            this.txtPassword.IsEnabled = IsEnabled;
        }
    }
}
