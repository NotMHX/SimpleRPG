using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ItemQuantity> ItemsRequirement { get; set; }


        public int RewardInXP { get; set; }
        public int RewardInGold { get; set; }
        public List<ItemQuantity> RewardInItems { get; set; }

        public Quest(int id, string name, string description, List<ItemQuantity> itemsRequirement, int rewardInXP, int rewardInGold, List<ItemQuantity> rewardInItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsRequirement = itemsRequirement;
            RewardInXP = rewardInXP;
            RewardInGold = rewardInGold;
            RewardInItems = rewardInItems;

            
        }

    }
}
