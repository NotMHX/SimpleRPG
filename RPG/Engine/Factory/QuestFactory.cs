using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factory
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemRequirements = new List<ItemQuantity>();
            List<ItemQuantity> rewardInItems = new List<ItemQuantity>();

            rewardInItems.Add(new ItemQuantity(9001, 5));
            rewardInItems.Add(new ItemQuantity(1002, 1));

            _quests.Add(new Quest(
             1,
             "Clear the tower",
             "Defeat the snakes in the Witch Tower",
             itemRequirements,
             25, 10,
             rewardInItems));
        }

        internal static Quest GetQuestID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id); // Gets the first result where the input matches an ID in the _quests list
        }
    }
}
