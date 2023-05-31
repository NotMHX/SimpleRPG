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

            itemRequirements.Add(new ItemQuantity(4002, 8));
            rewardInItems.Add(new ItemQuantity(2003, 1));

            _quests.Add(new Quest(
             1,
             "Get souls in the village",
             "Defeat 8 Ghost in the Village and get there souls",
             itemRequirements,
             25, 10,
             rewardInItems));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
