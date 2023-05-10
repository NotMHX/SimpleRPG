using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factory
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster werewolf =
                        new Monster("Werewolf", "Snake.png", 4, 4, 5, 1);
                    AddLootItem(werewolf, 9001, 25);
                    AddLootItem(werewolf, 9002, 75);
                    return werewolf;
                case 2:
                    Monster ghost =
                        new Monster("Ghost", "Rat.png", 5, 5, 5, 1);
                    AddLootItem(ghost, 9003, 25);
                    AddLootItem(ghost, 9004, 75);
                    return ghost;
                case 3:
                    Monster demon =
                        new Monster("Demon", "GiantSpider.png", 10, 10, 10, 3);
                    AddLootItem(demon, 9005, 25);
                    AddLootItem(demon, 9006, 75);
                    return demon;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}