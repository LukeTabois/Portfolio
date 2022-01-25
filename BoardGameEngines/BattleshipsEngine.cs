namespace BoardGameEngines
{
    /// <summary>
    /// 0 index based coordinates for arrays
    /// </summary>
    public class ArrayCoordinate
    {
        public int Column { get; set; }
        public int Row { get; set; }

    }

    /// <summary>
    /// for all the common and reusable methods for the game battleships
    /// </summary>
    public static class BattleshipsEngine
    {
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
        /// FOR TESTING PURPOSES
        /// adds hard coded boats to a grid to simulate grid within game play
        /// </summary>
        /// <param name="grid">the grid to add the mock boats to</param>
        /// <returns>the grid with the mock boats added</returns>
        public static string[,] MockAddBoatsToGrid(string[,] grid)
        {
            // carrier boat added from B2 to B6
            grid[1, 1] = "C";
            grid[1, 2] = "C";
            grid[1, 3] = "C";
            grid[1, 4] = "C";
            grid[1, 5] = "C";

            // battleship boat added from E9 to H9
            grid[5, 8] = "B";
            grid[6, 8] = "B";
            grid[7, 8] = "B";
            grid[8, 8] = "B";

            // destroyer boat added from D4 to D7
            grid[4, 3] = "D";
            grid[4, 4] = "D";
            grid[4, 5] = "D";

            // submarine boat added from H10 to J10
            grid[7, 9] = "S";
            grid[8, 9] = "S";
            grid[9, 9] = "S";

            // patrol boat added from A1 to A2
            grid[0, 0] = "P";
            grid[0, 1] = "P";

            // return the updated grid
            return grid;
        }

        public static bool Fire(ArrayCoordinate coordinate, string[,] inputGrid, out string[,] outputGrid )
        {            
            bool result = false;

            // inputGrid[coordinate.Column, coordinate.Row] = "!";

            if (inputGrid[coordinate.Column, coordinate.Row] == "O")
            {
                inputGrid[coordinate.Column, coordinate.Row] = "M";
            }
            else
            {
                inputGrid[coordinate.Column, coordinate.Row] = "H";
            }
            
            outputGrid = inputGrid;
            return result;
        }
    }

}