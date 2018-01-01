using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//**********************************
// Inventory class
// Will contain a list of Item objects
//**********************************

namespace _105_FinalPracticalStarter
{
    class Inventory
    {
		// Add any necessary fields here
		private List<Item> inventory;
		private double maxWeight;
		private double currentWeight;

        // Constructor
        public Inventory()
        {
			inventory = new List<Item>();
			maxWeight = 40;
			currentWeight = 0;
		}

		// Methods
		// These have been declared for you already.
		// All methods already include any necessary parameters.
		// See the practical documentation for more detailed information.

		// Adds an item to the inventory as long as it would not exceed
		// the inventory's total weight capacity.
		public bool AddItem(Item itemToAdd)
		{
			double hypothesisedWeight = itemToAdd.Weight + currentWeight;
			if (hypothesisedWeight <= maxWeight)
			{
				inventory.Add(itemToAdd);
				Console.WriteLine(itemToAdd.Name + " has been added");
				currentWeight = hypothesisedWeight;
				return true;
			}
			else
			{
				Console.WriteLine(itemToAdd.Name + " has not been added. It's too heavy");
				return false;
			}
		}

		// Repairs weapons (and only weapons) in the inventory
		public void RepairAllWeapons()
		{
			for (int i = 0; i < inventory.Count; i++)
			{
				if (inventory[i] is Weapon)
				{
					Weapon holder = (Weapon)inventory[i];
					holder.Repair();
					inventory[i] = holder;
				}
			}
			Console.WriteLine("All Weapons repaired");
		}

		// Prints out each and every item in the inventory
		public void PrintAllItems()
		{
			foreach (Item i in inventory)
			{
				Console.WriteLine(i.ToString());
			}
		}

		// Prints out weapons (and only weapons) in the inventory
		public void PrintAllWeapons()
		{
			foreach (Item i in inventory)
			{
				if (i is Weapon)
				{
					Console.WriteLine(i.ToString());
				}
			}
		}

		// Loads items from the file with the given name, 
		// and adds them to the inventory
		public void ReadData(string filename)
        {
			try
			{
				StreamReader reader = new StreamReader(filename);
				string data;
				string[] food = new string[4];
				string[] weapon = new string[5];
				while ((data = reader.ReadLine()) != null)
				{
					if (data.StartsWith("food"))
					{
						food = data.Split(',');
						this.AddItem(new Food(food[1], int.Parse(food[2]), double.Parse(food[3])));
					}
					else
					{
						weapon = data.Split(',');
						this.AddItem(new Weapon(weapon[1], int.Parse(weapon[2]), int.Parse(weapon[3]), double.Parse(weapon[4])));
					}
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		// Searches the inventory for an item with the specified name
        public Item Search(string itemName)
        {
			if (inventory.Count == 0)
			{
				Console.WriteLine("Your inventory is empty");
			}
			foreach(Item i in inventory)
			{
				if (i.Name.Trim().ToLower() == itemName.Trim().ToLower())
				{
					Console.WriteLine("Found " + itemName);
					return i;
				}
			}
			Console.WriteLine("No matching items found");
			return null;
        }
        
		// Returns the first item in the inventory (if it exists)
        public Item GetFirstItem()
        {
			if (inventory.Count == 0)
			{
				return null;
			}
			return inventory[0];
		}
        
		
	}
}
