using Battleships;
using BoardGameEngines;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsEngine.CreateNewGrid();
string[,] aiGrid = BattleshipsEngine.CreateNewGrid();

#if DEBUG
    // FOR TESTING ONLY, SHOULD BE REMOVED LATER
    // add hard coded boats to grid to simulate game
    BattleshipsEngine.MockAddBoatsToGrid(aiGrid);
#endif

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







