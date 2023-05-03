using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factory;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location _currentLocation;
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation 
        { 
            get { return _currentLocation; }
            set 
            { 
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToSouth");
            }
        }
        public bool HasLocationToNorth
        {
            get 
            { 
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; 
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public GameSession() {

            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Micheal";
            CurrentPlayer.CharacterClass = "Swordsman";
            CurrentPlayer.HitPoints = 69;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentLocation = new Location();
            CurrentLocation.Name = "" +
                "Player Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;

            CurrentLocation.Description = "This is your house.";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/house.png";

            Worldfactory factory = new Worldfactory();
            CurrentWorld = factory.Createworld();

            CurrentLocation = CurrentWorld.LocationAt(0,0);
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
