using BoardGameEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal static class BattleshipsConsole
    {
        internal static void PrintGrid(string[,] grid, bool showBoats = false)
        {
            // this loops through x axis (a b c...)
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                // if its the first time through the columns, add the column headers
                if (x == 0)
                {
                    Console.WriteLine("==========================================================================================");
                    Console.WriteLine("||      ||   A   |   B   |   C   |   D   |   E   |   F   |   G   |   H   |   I   |   J   |");
                    Console.WriteLine("==========================================================================================");
                }

                // changed index of y to match battleships grid
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    // if its the first time through the rows, add a row header
                    if (y == 0)
                    {
                        // handles the number 10 to keep the grid aligned
                        int rowNumber = x + 1;
                        if (rowNumber < 10)
                        {
                            Console.Write($"||  0{rowNumber}  ||");
                        }
                        else
                        {
                            Console.Write($"||  {rowNumber}  ||");
                        }
                        
                    }

                    // get the cell value
                    string valueAtCoordinate = grid[x, y];

                    // if the cell value is O, set it to a space
                    if (valueAtCoordinate == "O")
                    {
                        valueAtCoordinate = " ";
                    }

                    // if show boats is false
                    if (showBoats == false && valueAtCoordinate != "H" && valueAtCoordinate != "M")
                    {
                        valueAtCoordinate = " ";
                    }

                    // write the cell value with spacing either side
                    Console.Write($"   {valueAtCoordinate}   |");
                    
                }
                Console.WriteLine();

                // add a dashed line between each row
                Console.WriteLine("------------------------------------------------------------------------------------------");
            }
        }

        internal static ArrayCoordinate GetCoordinate()
        {
            // get input from user
            Console.WriteLine("Please enter a coordinate");
            string coordinate = Console.ReadLine().ToUpper();
            Console.WriteLine();

            // initialise row value
            int row = -1;

                // check coordinate is not empty
            if (!string.IsNullOrWhiteSpace(coordinate) &&
                // check first character between A and J
                (coordinate[0] >= 'A' && coordinate[0] <= 'J') &&
                // check subsequent characters are numbers between 1 and 10
                int.TryParse(coordinate.Substring(1), out row) && row >= 1 && row <= 10)                
            {
                // convert coordinate to array grid ready 
                int column = -1;
                switch (coordinate[0])
                {
                    case 'A':
                        column = 0;
                        break;
                    case 'B':
                        column = 1;
                        break;
                    case 'C':
                        column = 2;
                        break;
                    case 'D':
                        column = 3;
                        break;
                    case 'E':
                        column = 4;
                        break;
                    case 'F':
                        column = 5;
                        break;
                    case 'G':
                        column = 6;
                        break;
                    case 'H':
                        column = 7;
                        break;
                    case 'I':
                        column = 8;
                        break;
                    case 'J':
                        column = 9;
                        break;
                    default:
                        break;
                }
                row--;

                ArrayCoordinate result = new ArrayCoordinate();
                result.Column = column;
                result.Row = row;

                return result;

            }
            else // display error and recall this method
            {
                Console.WriteLine("The coordinate you entered is invalid");
                Console.WriteLine("Please enter a column (A-J) and row (1-10) with no spaces");
                Console.WriteLine("For example, A1");
                Console.WriteLine();
                return GetCoordinate();
            }


            throw new Exception("Error occurred trying to get coordinate");
        }

        /// <summary>
        /// gets a full name of a boat based on the letter
        /// </summary>
        /// <param name="boatLetter">first initial of a boat (P, B, D, S, C)</param>
        /// <returns>boat name based on corresponding boat letter</returns>
        public static string GetNameOfBattleShip(string boatLetter)
        {
            // initialise boat name
            string boatName = null;

            // sets boat name based on the letter
            switch (boatLetter)
            {
                case "P":
                    boatName = "Patrol Boat";
                    break;
                case "B":
                    boatName = "Battleship";
                    break;
                case "D":
                    boatName = "Destroyer";
                    break;
                case "S":
                    boatName = "Submarine";
                    break;
                case "C":
                    boatName = "Carrier";
                    break;
                // give an error if boat letter is not valid
                default:
                    Console.WriteLine($"{boatLetter} is not a valid boat letter. It must be P, D, S, B or C");
                    break;
            }

            return boatName;

        }

    }
}
