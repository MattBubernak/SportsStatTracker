using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStatTracker.ViewModels
{
    class TeamSelectionViewModel
    {
        private static TeamSelectionViewModel _instance = null;

        private TeamSelectionViewModel()
        {

        }

        public TeamSelectionViewModel getInstance()
        {
            if (_instance == null)
            {
                _instance = new TeamSelectionViewModel();
            }
            return _instance;
        }
    }
}
