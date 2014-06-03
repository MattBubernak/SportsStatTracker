using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SportStatTracker.Models;

namespace SportStatTracker.ViewModels
{
    class TeamSelectionViewModel
    {
        private static TeamSelectionViewModel _instance = null;
        public ObservableCollection<Models.DataBaseContext.Team> Teams { get; set; }

        private TeamSelectionViewModel()
        {
            //should populate the teams from the DB 
            populate_teams(); 
        }

        public TeamSelectionViewModel getInstance()
        {
            if (_instance == null)
            {
                _instance = new TeamSelectionViewModel();
            }
            return _instance;
        }

        //populates Teams with the teams from the DB 
        public void populate_teams()
        {

        }
    }
}
