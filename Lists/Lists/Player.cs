using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Player
    {

        List<String> inventory;




        public Player()
        {
            inventory = new List<string>();
        }


        public void AddToInv(string item)
        {
            inventory.Add(item);
        }


        public string GetItemInSlot(int index)
        {
            if (0 <= index && index < inventory.Count())
            {
                string holder = inventory[index];
                inventory.RemoveAt(index);
                return holder;
            }
            return null;
        }

        public void PrintInv()
        {
            foreach (string i in inventory)
            {
                Console.WriteLine(i);
            }
        }


    }
}
 