using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal static class BattleshipsConsole
    {
        internal static void PrintGrid(string[,] grid)
        {
            // this loops through x axis (a b c...)
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                // changed index of y to match battleships grid
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    string column = " ";
                    switch (x)
                    {
                        case 0:
                            column = "A";
                            break;
                        case 1:
                            column = "B";
                            break;
                        case 2:
                            column = "C";
                            break;
                        case 3:
                            column = "D";
                            break;
                        case 4:
                            column = "E";
                            break;
                        case 5:
                            column = "F";
                            break;
                        case 6:
                            column = "G";
                            break;
                        case 7:
                            column = "H";
                            break;
                        case 8:
                            column = "I";
                            break;
                        case 9:
                            column = "J";
                            break;
                        default:
                            break;
                    }

                    string row = (y + 1).ToString();

                    Console.WriteLine($"{column}{row} {grid[x, y]}");

                }
            }
        }
    }
}
