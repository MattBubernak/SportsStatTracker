using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SportStatTracker.Views
{
    public partial class AddPlayer : PhoneApplicationPage
    {
        const string INVALID_NUMBER_MESSAGE = "Invalid Number";
        const string ERROR_MESSAGE_TITLE = "Error";  

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void Save_Player(object sender, EventArgs e)
        {
           

            //confirm that player number is an integer, otherwise throw error
            int playerNumber;
            if (Int32.TryParse(NumberBox.Text.ToString(), out playerNumber) == false)
            {
                Show_Error_Message(INVALID_NUMBER_MESSAGE);
            }

        }

        private void Show_Error_Message(string message)
        {
            MessageBoxResult result = MessageBox.Show(message, ERROR_MESSAGE_TITLE, MessageBoxButton.OK);
        }

    }
}