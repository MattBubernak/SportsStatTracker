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
    public partial class TeamPage : PhoneApplicationPage
    {
        public TeamPage()
        {
            InitializeComponent();
            //update the panorama appbar the first time the page loads
            UpdatePanoramaAppBar(0);
        }

        private void PanoramaSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int currentPanoramaIndex = PanoramaControl.SelectedIndex;
            UpdatePanoramaAppBar(currentPanoramaIndex);
        }

        private void add_player(object sender, EventArgs e)
        {

        }

        private void add_game(object sender, EventArgs e)
        {

        }

        private void UpdatePanoramaAppBar(int index)
        {

            //create a new application bar
            ApplicationBar = new ApplicationBar();

            switch (index)
            {
                case 0:
                    //create a button for new player 
                    ApplicationBarIconButton newGame = new ApplicationBarIconButton();
                    //populate the button information 
                    newGame.Text = "Add Game";
                    newGame.IconUri = new Uri("/Images/add.png", UriKind.Relative);
                    newGame.Click += new EventHandler(add_game);
                    //add the button to the application bar 
                    ApplicationBar.Buttons.Add(newGame);
                    break;
                case 1:
                    //create a button for new player 
                    ApplicationBarIconButton newPlayer = new ApplicationBarIconButton();
                    //populate the button information 
                    newPlayer.Text = "Add Player";
                    newPlayer.IconUri = new Uri("/Images/add.png", UriKind.Relative);
                    newPlayer.Click += new EventHandler(add_player);
                    //add the button to the application bar 
                    ApplicationBar.Buttons.Add(newPlayer);

                    break;
                case 2:


                    break;
            }
        }


    }
}