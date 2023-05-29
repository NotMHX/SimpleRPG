using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factory
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 2, 0, 2));
            _standardGameItems.Add(new Weapon(1002, "Small Rock", 2, 1, 3));
            _standardGameItems.Add(new Weapon(2001, "Rusty Sword", 5, 1, 3));
            _standardGameItems.Add(new Weapon(2002, "Kitchen Knife", 10, 3, 8));
            _standardGameItems.Add(new Weapon(2003, "Japanese Katana", 30, 10, 18));
            _standardGameItems.Add(new Weapon(3001, "Wooden Bow", 20, 0, 10));
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                if(standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}
