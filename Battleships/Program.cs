using Battleships;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsConsole.CreateNewGrid();
string[,] aiGrid = BattleshipsConsole.CreateNewGrid();

// print grid
BattleshipsConsole.PrintGrid(playerGrid, true);
Console.WriteLine();

// call place ship passing inputs
bool isBoatPlacementValid = BattleshipsConsole.PlaceShip(playerGrid, out playerGrid);
if (isBoatPlacementValid == false)
{
    Console.WriteLine("Boat placement was not valid");
}

// print grid 
BattleshipsConsole.PrintGrid(playerGrid, true);
Console.WriteLine();

// FOR TESTING ONLY, SHOULD BE REMOVED LATER
return;

bool allBoatsSunk = BattleshipsConsole.Fire(aiGrid, out aiGrid);

// print grid after fire
BattleshipsConsole.PrintGrid(aiGrid);

#if DEBUG
    // stop point for debugging purposes
    Console.ReadLine();
#endif