using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Alex_WK1Assessment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            // if user id is Alex01 and password is Password1
            // Display message "Login successful" followed by the user ID
            string storedUserName = "Alex01";
            string storedPassword = "Password1";

            string userName = txtUserName.Text;
            string password = txtPassword.Text;


            if (storedUserName == userName && storedPassword == password)
            {
                txtOutput.Text = "Login successful, " + userName;
            }
            else
            {
                // if user id or password does not match the values above 
                // Display message "Login failed" followed by the user ID entered
                txtOutput.Text = "Login Failed, " + userName;
            }    
        }

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            // Clear the User ID and Password fields and any messages that have been displayed
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtOutput.Text = string.Empty;
        }
    }
}
