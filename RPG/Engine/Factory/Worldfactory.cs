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
            if (File.Exists(GAME_DATA_FILENAME))
            {
                XmlDocument data = new XmlDocument();
                data.LoadXml(File.ReadAllText(GAME_DATA_FILENAME));
                string rootImagePath =
                    data.SelectSingleNode("/Locations")
                        .AttributeAsString("RootImagePath");
                LoadLocationsFromNodes(world,
                                       rootImagePath,
                                       data.SelectNodes("/Locations/Location"));
            }
            else
            {
                throw new FileNotFoundException($"Missing data file: {GAME_DATA_FILENAME}");
            }
            return world;
        }
    }
}
