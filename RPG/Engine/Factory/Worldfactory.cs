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
        internal World Createworld()
        {
            World world = new World();
            world.AddLocation(0,-1,"Home", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(0, 0, "Village", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(0, 1, "Forest", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(0, 2, "Witch-Tower", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(-1, 0, "Graveyard", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(1, 0, "Animals", "This is your house.", "/Engine;component/Images/Locations/house.png");
            world.AddLocation(1, 1, "Castle", "This is your house.", "/Engine;component/Images/Locations/house.png");
            return world;
        }
    }
}
