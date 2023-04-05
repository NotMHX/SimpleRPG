using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurerntPlayer { get; set; }
        public GameSession() {

            CurerntPlayer = new Player();
            CurerntPlayer.Name = "Micheal";
            CurerntPlayer.CharacterClass = "Swordsman";
            CurerntPlayer.HitPoints = 69;
            CurerntPlayer.Gold = 1000000;
            CurerntPlayer.ExperiencePoints = 0;
            CurerntPlayer.Level = 1;
        }

    }
}
