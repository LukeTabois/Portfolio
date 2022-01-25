using Battleships;
using BoardGameEngines;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsEngine.CreateNewGrid();
string[,] aiGrid = BattleshipsEngine.CreateNewGrid();

// print grid before Fire
BattleshipsConsole.PrintGrid(aiGrid);

// get a coordinate from the player
ArrayCoordinate coordinate = BattleshipsConsole.GetCoordinate();

// fire based on player input against aiGrid
BattleshipsEngine.Fire(coordinate, aiGrid, out aiGrid);

// print grid after Fire
BattleshipsConsole.PrintGrid(aiGrid);

#if DEBUG
    // stop point for debugging purposes
    Console.ReadLine();
#endif







