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
                        new Monster("Werewolf", "werewolf.png", 4, 4,3,5, 5, 1);
                    AddLootItem(werewolf, 1002, 75);
                    AddLootItem(werewolf, 2001, 25);
                    return werewolf;
                case 2:
                    Monster ghost =
                        new Monster("Ghost", "ghost.png", 5, 5,1,3, 5, 1);
                    AddLootItem(ghost, 1001, 80);
                    AddLootItem(ghost, 2002, 20);
                    return ghost;
                case 3:
                    Monster demon =
                        new Monster("Demon", "demon.png", 10, 10, 3, 6, 10, 310);
                    AddLootItem(demon, 2001, 80);
                    AddLootItem(demon, 3001, 15);
                    AddLootItem(demon, 2003, 5);
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