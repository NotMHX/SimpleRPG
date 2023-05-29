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
        public World CreateWorld()
        {
            World world = new World();
            world.AddLocation(-1 ,0,"Home", "This is your house.", "house.png");
            world.AddLocation(0, 0, "Village", "This is the village square.", "village.png");
            world.LocationAt(0,0).AddMonster(2, 30);
            world.AddLocation(1, 0, "Forest", "This is a very scary forest.", "forest.png");
            world.LocationAt(1, 0).AddMonster(1, 100);
            world.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            world.AddLocation(2, 0, "Witch Tower", "This is a spooky Witch Tower. I wonder if there's a witch here.", "witch tower.png");
            world.LocationAt(2, 0).AddMonster(3, 100);
            world.AddLocation(0, -1, "Graveyard", "This is where the dead are buried. I hope nobody is alive.", "graveyard.png");
            world.AddLocation(0, 1, "Zoo", "There's animals here.", "animals.png");
            world.AddLocation(1, 1, "Castle", "The all-mighty castle of the village", "castle.png");
            return world;
        }
    }
}
