using System;

namespace Homework1_Dungeon_Starter
{
	class Program
	{
		static void Main(string[] args)
		{
			// Clears the screen (in case the IGM labs have a warning message)
			Console.Clear();

			// Creates a Dungeon object, which contains the code to draw
			// a map in the console.  This map is 100 columns by 30 rows.
			Dungeon dungeon = new Dungeon("Sample Dungeon", 100, 30);
			// Change the numbers above if you'd like a different size!

			// Builds the dungeon ------------------------------------
			// This code creates the left hand room.  The following can be done
			// in any order, but has been broken up by the type of object for
			// ease of reading.  Feel free to rearrange these if you need to.

			// Draw the walls first
			dungeon.DrawWallHorizontal(1, 0, 10);   // Draw the top wall
			dungeon.DrawWallVertical(0, 1, 6);      // Draw left wall
			dungeon.DrawWallHorizontal(1, 7, 10);   // Draw the bottom wall	
			dungeon.DrawWallVertical(11, 1, 1);     // Draw top right wall
			dungeon.DrawWallVertical(11, 5, 2);     // Draw bottom right wall

			// Wall corners
			dungeon.DrawWallCorner(0, 0, WallCorner.TopLeft);
			dungeon.DrawWallCorner(11, 0, WallCorner.TopRight);
			dungeon.DrawWallCorner(0, 7, WallCorner.BottomLeft);
			dungeon.DrawWallCorner(11, 7, WallCorner.BottomRight);
			dungeon.DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
			dungeon.DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

			// Objects in the dungeon
			dungeon.DrawObject(3, 2, '@');                          // Add the explorer
			dungeon.DrawObject(5, 6, 'W', ConsoleColor.Green);      // Add a weapon

			// Add more code here!
			// And here...
			// And here...
			// Etc.







			// The following lines ensure the cursor ends up near the bottom
			// of the console window when the program ends.  Make sure this
			// happens last by only adding code above these lines.
			Console.CursorTop = Console.WindowHeight - 1;
			Console.CursorLeft = 0;
		}
	}
}
