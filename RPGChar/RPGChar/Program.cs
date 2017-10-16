using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChar
{
	class Program
	{
		static void Main(string[] args)
		{
			RPGChara myChar = new RPGChara("Zera", 12, 24, 16, 7);

			//begin
			myChar.PrintChar();

			myChar.LowerHP();
			myChar.LowerHP();
			myChar.LowerHP();
			myChar.LowerHP();
			myChar.IncreaseDex();
			myChar.IncreaseStr();
			myChar.IncreaseInt();

			//end
			myChar.PrintChar();
		}
	}
}
