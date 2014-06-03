using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SportStatTracker.ViewModels;

namespace SportStatTracker.Views
{
    public partial class TeamSelectionPage : PhoneApplicationPage
    {
        public TeamSelectionPage()
        {
            InitializeComponent();
            UpdatePanoramaAppBar(0);
            DataContext = TeamSelectionViewModel.getInstance(); 
        }

        private void Add_Team(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/AddTeam.xaml", UriKind.Relative));

        }

        private void PanoramaSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int currentPanoramaIndex = PanoramaControl.SelectedIndex;
            UpdatePanoramaAppBar(currentPanoramaIndex);
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
                    newGame.Click += new EventHandler(Add_Team);
                    //add the button to the application bar 
                    ApplicationBar.Buttons.Add(newGame);
                    break;
                case 1:

                    break;

            }
        }



    }
}