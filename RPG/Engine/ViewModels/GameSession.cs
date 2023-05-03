using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factory;
namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
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


        }
    }
}
