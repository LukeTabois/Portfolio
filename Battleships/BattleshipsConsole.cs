namespace Battleships
{
    public static class BattleshipsConsole
    {
        /// <summary>        
        /// adds hard coded boats to a grid for an AI
        /// </summary>
        /// <param name="grid">the grid to add the mock boats to</param>
        /// <returns>the grid with the mock boats added</returns>
        public static string[,] AddBoatsToAiGrid(string[,] grid)
        {
            // TODO: replace with intellegence for AI place boats
            
            // carrier boat added from B2 to B6
            grid[1, 1] = "H";
            grid[1, 2] = "H";
            grid[1, 3] = "H";
            grid[1, 4] = "H";
            grid[1, 5] = "C";

            // battleship boat added from E9 to H9
            grid[5, 8] = "H";
            grid[6, 8] = "H";
            grid[7, 8] = "H";
            grid[8, 8] = "H";

            // destroyer boat added from D4 to D7
            grid[4, 3] = "H";
            grid[4, 4] = "H";
            grid[4, 5] = "H";

            // submarine boat added from H10 to J10
            grid[7, 9] = "H";
            grid[8, 9] = "H";
            grid[9, 9] = "H";

            // patrol boat added from A1 to A2
            grid[0, 0] = "H";
            grid[0, 1] = "P";

            // return the updated grid
            return grid;
        }

        /// <summary>
        /// gets a coordinate from a user
        /// </summary>
        public static ArrayCoordinate GetCoordinate(string displayMessage)
        {
            // get input from user
            Console.WriteLine(displayMessage);
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
                return GetCoordinate(displayMessage);
            }


            throw new Exception("Error occurred trying to get coordinate");
        }

        /// <summary>
        /// creates a new 10 x 10 battleships grid
        /// </summary>
        /// <returns>a battleships grid</returns>
        public static string[,] CreateNewGrid()
        {
            // Two-dimensional array (X, Y).
            string[,] grid = new string[10, 10];

            // this loops through x axis (a b c...)
            for (int x = 0; x < 10; x++)
            {
                // changed index of y to match battleships grid
                for (int y = 0; y < 10; y++)
                {
                    grid[x, y] = "O";
                }
            }

            // return array
            return grid;
        }

        /// <summary>
        /// displays a battleship grid on the console
        /// </summary>
        /// <param name="grid">grid to display</param>
        /// <param name="showBoats">determines if boats should be displayed or hidden</param>
        public static void PrintGrid(string[,] grid, bool showBoats = false)
        {
            // this loops through x axis (a b c...)
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                // if its the first time through the columns, add the column headers
                if (x == 0)
                {
                    Console.WriteLine("=========================================================================================");
                    Console.WriteLine("||     ||   1   |   2   |   3   |   4   |   5   |   6   |   7   |   8   |   9   |   10  |");
                    Console.WriteLine("=========================================================================================");
                }

                // changed index of y to match battleships grid
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    // convert coordinate to array grid ready 
                    string column = null;
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
                    // if its the first time through the rows, add a row header
                    if (y == 0)
                    {
                        Console.Write($"||  {column}  ||");

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
                Console.WriteLine("-----------------------------------------------------------------------------------------");
            }
        }

        /// <summary>
        /// places a specified boat onto a provided grid
        /// </summary>
        /// <param name="grid">grid to place the boat on</param>
        /// <param name="boatLetter">letter that represents the boat</param>
        /// <returns>true/false value to determine if the boat was placed successfully</returns>
        public static string[,] PlaceShip(string[,] grid, string boatLetter)
        {
            // initialise outputs                        
            string[,] copyOfGrid = grid;
            
            // get basic inputs for place ship                        
            ArrayCoordinate startCoordinate = GetCoordinate("PLEASE ENTER YOUR THE BOATS FIRST COORDINATE");
                        
            ArrayCoordinate endCoordinate = GetCoordinate("PLEASE ENTER YOUR THE BOATS LAST COORDINATE");

            // check boat is not at an angle
            if (startCoordinate.Column != endCoordinate.Column && startCoordinate.Row != endCoordinate.Row)
            {
                Console.WriteLine("Boats cannot be placed at an angle");
                Console.WriteLine();                
                return PlaceShip(grid, boatLetter);
            }

            // check size of boat is correct
            int expectedBoatLength = -1;
            switch (boatLetter)
            {
                case "P":
                    expectedBoatLength = 2;
                    break;
                case "S":
                    expectedBoatLength = 3;
                    break;
                case "D":
                    expectedBoatLength = 3;
                    break;
                case "B":
                    expectedBoatLength = 4;
                    break;
                case "C":
                    expectedBoatLength = 5;
                    break;
                default:
                    Console.WriteLine($"{boatLetter} is not a valid boat type");
                    Console.WriteLine();
                    return PlaceShip(grid, boatLetter);
                    break;
            }

            // check that same boat is not used twice
            for (int x = 0; x < copyOfGrid.GetLength(0); x++)
            {
                for (int y = 0; y < copyOfGrid.GetLength(1); y++)
                {
                    if(copyOfGrid[x,y] == boatLetter)
                    {
                        Console.WriteLine("Boat has already been placed");
                        Console.WriteLine();
                        return PlaceShip(grid, boatLetter);
                    }
                }
            }
            
            // initialise variables needed for placing the boat
            ArrayCoordinate coordinateCounter;
            int providedBoatLength;

            // if the boat is horizontal                       
            if (startCoordinate.Column == endCoordinate.Column)
            {
                // check and set start coordinate as the "smaller" value
                if (startCoordinate.Row > endCoordinate.Row)
                {
                    ArrayCoordinate tempCoordinate = startCoordinate;
                    startCoordinate = endCoordinate;
                    endCoordinate = tempCoordinate;
                }

                // check boat length is valid
                providedBoatLength = (endCoordinate.Row - startCoordinate.Row) + 1;
                if (providedBoatLength != expectedBoatLength)
                {
                    Console.WriteLine($"Coordinates provided do not match lenth of the boat ({expectedBoatLength})");
                    Console.WriteLine();
                    return PlaceShip(grid, boatLetter);
                }

                // set coordinate counter as start coordinate 
                coordinateCounter = startCoordinate;                

                // setting the boat letter for the start to end coordinates
                while (coordinateCounter.Row <= endCoordinate.Row)
                {
                    // check if there is boat in that position
                    if (copyOfGrid[coordinateCounter.Column, coordinateCounter.Row] != "O")
                    {
                        Console.WriteLine("Boats cannot intersect");
                        Console.WriteLine();
                        return PlaceShip(grid, boatLetter);
                    }

                    copyOfGrid[coordinateCounter.Column, coordinateCounter.Row] = boatLetter;
                    coordinateCounter.Row++;
                }
                
            }
            // if the boat is vertical
            else
            {
                // check and set start coordinate as the "smaller" value
                if (startCoordinate.Column > endCoordinate.Column)
                {
                    ArrayCoordinate tempCoordinate = startCoordinate;
                    startCoordinate = endCoordinate;
                    endCoordinate = tempCoordinate;
                }

                // check boat length is valid
                providedBoatLength = (endCoordinate.Column - startCoordinate.Column) + 1;
                if (providedBoatLength != expectedBoatLength)
                {
                    Console.WriteLine($"Coordinates provided do not match lenth of the boat ({expectedBoatLength})");
                    Console.WriteLine();
                    return PlaceShip(grid, boatLetter);
                }

                // set coordinate counter as start coordinate 
                coordinateCounter = startCoordinate;                

                // setting the boat letter for the start to end coordinates
                while (coordinateCounter.Column <= endCoordinate.Column)
                {
                    // check if there is boat in that position
                    if (copyOfGrid[coordinateCounter.Column, coordinateCounter.Row] != "O")
                    {
                        Console.WriteLine("Boats cannot intersect");
                        Console.WriteLine();
                        return PlaceShip(grid, boatLetter);
                    }

                    copyOfGrid[coordinateCounter.Column, coordinateCounter.Row] = boatLetter;
                    coordinateCounter.Column++;
                }
                
            }

            // if all is ok return the working copy            
            return copyOfGrid;
        }

        /// <summary>
        /// simulates firing in a game of battleships
        /// </summary>
        /// <param name="grid">grid before the shot</param>
        /// <param name="gridPostShot">grid after the shot</param>
        /// <param name="allBoatsWereSunk">true/false if all boats have been sunk</param>
        /// <returns>true/false if boat was hit</returns>
        public static bool Fire(string[,] grid, bool isPlayerTurn, out string[,] gridPostShot, out bool allBoatsWereSunk)
        {
            // initialise variables needed for fire
            bool shotAlready = true;
            allBoatsWereSunk = false;
            string playerOrAi = null;

            if(isPlayerTurn == true)
            {
                playerOrAi = "PLAYER";
            }
            else
            {
                playerOrAi = "COMPUTER";
            }

            // loop is the coordinate has already been fired against
            while (shotAlready == true)
            {
                ArrayCoordinate coordinate = GetCoordinate("PLEASE ENTER A COORDINATE TO FIRE AT");

                // check if coordinate has NOT been fired upon already
                if (!(grid[coordinate.Column, coordinate.Row] == "M") && !(grid[coordinate.Column, coordinate.Row] == "H"))
                {
                    // prevent loop by setting shot already to false
                    shotAlready = false;

                    // if not fired upon and no boat
                    if (grid[coordinate.Column, coordinate.Row] == "O")
                    {
                        // set to miss
                        grid[coordinate.Column, coordinate.Row] = "M";
                    }
                    // otherwise
                    else
                    {
                        string boatLetter = grid[coordinate.Column, coordinate.Row];

                        // set to hit
                        grid[coordinate.Column, coordinate.Row] = "H";

                        // get name of the boat that was hit
                        string boatName = GetNameOfBattleShip(boatLetter);

                        // output that a boat was hit
                        Console.WriteLine($"THE {playerOrAi} HIT A {boatName.ToUpper()}");                        

                        // check if boat sunk and set to boat letter                 
                        if (IsShipSunk(boatLetter, grid, out allBoatsWereSunk))
                        {
                            // output that a boat was hit
                            Console.WriteLine($"THE {playerOrAi} SUNK A {boatName.ToUpper()}");                            

                            if (allBoatsWereSunk == true)
                            {
                                Console.WriteLine("--------------------------------------------------------------");
                                Console.WriteLine($"                   {playerOrAi} WINS!!                       ");
                                Console.WriteLine("--------------------------------------------------------------");
                                Console.WriteLine();                                                                
                            }
                        }                       
                        
                        gridPostShot = grid;
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("You stupid fuckin moron pick another");
                    Console.WriteLine();
                }
            }

            gridPostShot = grid;
            return false;
        }

        /// <summary>
        /// checks if a boat is sunk
        /// </summary>
        /// <param name="boatLetter">represents a type of boat</param>
        /// <param name="grid">the battleship grid</param>
        /// <returns>true or false value if a boat has been sunk</returns>
        public static bool IsShipSunk(string boatLetter, string[,] grid, out bool areAllShipsSunk)
        {
            // initilise sunk
            bool isShipSunk = true;
            areAllShipsSunk = false;

            // check if the boat letter is in the array
            // this loops through x axis (a b c...)
            for (int x = 0; x < 10; x++)
            {
                // changed index of y to match battleships grid
                for (int y = 0; y < 10; y++)
                {
                    // check is boatletter is in the cell
                    if (boatLetter == grid[x, y])
                    {
                        isShipSunk = false;
                    }
                }
            }

            // if the ship was sunk
            if (isShipSunk == true)
            {
                areAllShipsSunk = AreAllShipsSunk(grid);
            }

            // return sunk
            return isShipSunk;
        }

        /// <summary>
        /// checks if all boats have been sunk
        /// </summary>
        /// <param name="grid">battleship grid</param>
        /// <returns>if all the boats have been sunk</returns>
        public static bool AreAllShipsSunk(string[,] grid)
        {
            // initialise the hit counter
            int hitCounter = 0;

            // check if H is in the array
            // this loops through x axis (a b c...)
            for (int x = 0; x < 10; x++)
            {
                // changed index of y to match battleships grid
                for (int y = 0; y < 10; y++)
                {
                    // check if H is in the cell
                    if ("H" == grid[x, y])
                    {
                        hitCounter++;
                    }
                }
            }

            // using 17 as that is the total boat slots
            if (hitCounter == 17)
            {
                return true;
            }
            else
            {
                return false;
            }
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

    /// <summary>
    /// 0 index based coordinates for arrays
    /// </summary>
    public class ArrayCoordinate
    {
        public int Column { get; set; }
        public int Row { get; set; }
    }

    
}
