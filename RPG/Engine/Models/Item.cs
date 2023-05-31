using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Item : GameItem
    {
       
        public Item (int itemTypeID, string name, int price) : base(itemTypeID, name, price)
        {
           
        }

        public new Item Clone()
        {
            return new Item(ItemTypeID, Name, Price);
        }
    }
}
