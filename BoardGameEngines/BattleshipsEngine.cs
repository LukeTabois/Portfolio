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

        public static bool Fire(ArrayCoordinate coordinate, string[,] inputGrid, out string[,] outputGrid )
        {            
            bool result = false;

            inputGrid[coordinate.Column, coordinate.Row] = "!";
            
            outputGrid = inputGrid;
            return result;
        }
    }

}