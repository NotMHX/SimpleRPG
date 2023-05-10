using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factory
{
    internal class Worldfactory
    {
        internal World CreateWorld()
        {
            World world = new World();
            world.AddLocation(0,-1,"Home", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(0, 0, "Village", "This is the village square.", "/Engine;component/Images/Locations/house.png");
            world.LocationAt(0,0).AddMonster(2, 30);
            world.AddLocation(0, 1, "Forest", "This is a very scary forest.", "/Engine;component/Images/Locations/house.png");
            world.LocationAt(0, 1).AddMonster(1, 100);
            world.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            world.AddLocation(0, 2, "Witch Tower", "This is a spooky Witch Tower. I wonder if there's a witch here.", "/Engine;component/Images/Locations/house.png");
            world.LocationAt(0, 2).AddMonster(3, 100);
            world.AddLocation(-1, 0, "Graveyard", "This is where the dead are buried. I hope nobody is alive.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(1, 0, "Zoo", "There's animals here.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(1, 1, "Castle", "The all-mighty castle of the village", "/Engine;component/Images/Locations/house.png");
            return world;
        }
    }
}
