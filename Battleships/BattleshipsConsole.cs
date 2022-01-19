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
                    Console.Write(column + row);                  
                    
                }
                Console.WriteLine();
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


    }
}
