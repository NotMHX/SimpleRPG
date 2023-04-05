using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player Currentplay { get; set; }
        public GameSession() {
        
        Currentplay= new Player();

            Currentplay.Name = "Micheal";
            Currentplay.Level = 1;
            Currentplay.HitPoints = 5;
            Currentplay.ExperiencePoints = 0;
            Currentplay.CharacterClass = "Swordsman";
            Currentplay.Gold = 2;
        }

    }
}
