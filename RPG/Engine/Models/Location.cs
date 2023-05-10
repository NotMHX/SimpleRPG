using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Engine.Factory;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
  public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();


        public List<MonsterEncounter> MonstersHere { get; set; } = new List<MonsterEncounter>();

        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if (MonstersHere.Exists(m => m.MonsterID == monsterID)) // If there is a monster already
            {
                MonstersHere.First(m => m.MonsterID == monsterID).ChanceOfEncountering = chanceOfEncountering; // Add chance to existing monster
            }
            else
            {
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering)); // Adds new monster if there's none yet
            }
        }

        public Monster GetMonster()
        {
            if (!MonstersHere.Any())
            {
                return null; // If there's no monster
            }

            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncountering); // Total chance of encountering

            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);

            int total = 0;

            foreach (MonsterEncounter monsterEncounter in MonstersHere)
            {
                total += monsterEncounter.ChanceOfEncountering; // adds current chance to total

                if (randomNumber <= total) // if total is less than the max number of monsters
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                }
            }

            // if there's none
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);

        }

       
    }
}
