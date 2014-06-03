using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SportStatTracker.Models
{
    public class DataBaseContext : DataContext
    {
        // Pass the connection string to the base class.
        public DataBaseContext(string connectionString)
            : base(connectionString)
        { }
        
        // Specify a table for the to-do items.
        public Table<Team> Teams;

        #region Team
        [Table]
        public class Team : INotifyPropertyChanged, INotifyPropertyChanging
        {

            
            // Define ID: private field, public property, and database column.
            private int _teamID;

            [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
            public int teamID
            {
                get { return _teamID; }
                set
                {
                    if (_teamID != value)
                    {
                        NotifyPropertyChanging("teamID");
                        _teamID = value;
                        NotifyPropertyChanged("teamID");
                    }
                }
            }

            // Define item name: private field, public property, and database column.
            private string _teamName;

            [Column]
            public string teamName
            {
                get { return _teamName; }
                set
                {
                    if (_teamName != value)
                    {
                        NotifyPropertyChanging("teamName");
                        _teamName = value;
                        NotifyPropertyChanged("teamName");
                    }
                }
            }


            private string _teamSport;
            [Column]
            public string teamSport
            {
                get { return _teamSport; }
                set
                {
                    if (_teamSport != value)
                    {
                        NotifyPropertyChanging("teamSport");
                        _teamSport = value;
                        NotifyPropertyChanged("teamSport");
                    }
                }
            }


            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            // Used to notify that a property changed
            private void NotifyPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            #endregion

            #region INotifyPropertyChanging Members

            public event PropertyChangingEventHandler PropertyChanging;

            // Used to notify that a property is about to change
            private void NotifyPropertyChanging(string propertyName)
            {
                if (PropertyChanging != null)
                {
                    PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
                }
            }

            #endregion
        }
        #endregion




    }


}
