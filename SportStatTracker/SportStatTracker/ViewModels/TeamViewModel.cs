using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStatTracker.Models;
using SportStatTracker.ViewModels;


namespace SportStatTracker.ViewModels
{
    public class TeamViewModel
    {
        //why can't I just use Team??
        private Models.DataBaseContext.Team _team;


        public Models.DataBaseContext.Team Team
        {
            get { return _team; }
            set { _team = value; }
        }

         
    }
}
