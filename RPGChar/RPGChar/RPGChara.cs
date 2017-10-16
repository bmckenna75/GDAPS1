using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChar
{
	class RPGChara
	{

		private string name;
		private int strength = 0;
		private int dex = 0;
		private int intel = 0;
		private int hp = 0;
		private int otherdex = 0;

		//constructor
		public RPGChara(string title, int streng, int dext, int intelligence, int health)
		{
			name = title;
			strength = streng;
			dex = dext;
			intel = intelligence;
			hp = health;
			otherdex = (hp + dex) / 4;
		}
		//methods


		//increase methods

		public void IncreaseStr()
		{
			strength++;
			Console.WriteLine("Str incresed by 1");
		}

		public void IncreaseDex()
		{
			dex++;
			Console.WriteLine("Dex incresed by 1");
			otherdex = (hp + dex) / 4;
		}

		public void IncreaseInt()
		{
			intel++;
			Console.WriteLine("Int incresed by 1");
		}

		public void IncreaseHP()
		{
			hp++;
			Console.WriteLine("HP incresed by 1");
			otherdex = (hp + dex) / 4;
		}

		//decrease methods

		public void LowerStr()
		{
			strength--;
			Console.WriteLine("Str Lowered by 1");
		}
		public void LowerDex()
		{
			dex--;
			Console.WriteLine("Dex Lowered by 1");
			otherdex = (hp + dex) / 4;
		}
		public void LowerInt()
		{
			intel--;
			Console.WriteLine("Int Lowered by 1");
		}
		public void LowerHP()
		{
			hp--;
			Console.WriteLine("HP Lowered by 1");
			otherdex = (hp + dex) / 4;
		}

		//stat print method
		public void PrintChar()
		{
			Console.WriteLine("\n\n" + name + "\n\nStr : " + strength + "\nDex : " + dex + "\nInt : " + intel + "\nHP : " + hp + "\nSpeed : " + otherdex);
		}



	}
}
