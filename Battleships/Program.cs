using Battleships;
using BoardGameEngines;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsEngine.CreateNewGrid();
string[,] aiGrid = BattleshipsEngine.CreateNewGrid();
bool boatWasHit = false;
bool boatWasSunk = false;

#if DEBUG
    // FOR TESTING ONLY, SHOULD BE REMOVED LATER
    // add hard coded boats to grid to simulate game
    BattleshipsEngine.MockAddBoatsToGrid(aiGrid);
#endif

// print grid before Fire
BattleshipsConsole.PrintGrid(aiGrid, true);

return;

// initialise shotAlready to enter loop and the coordinate object
bool shotAlready = true;
ArrayCoordinate coordinate = null;

while (shotAlready == true)
{    
    coordinate = BattleshipsConsole.GetCoordinate();
    shotAlready = BattleshipsEngine.Fire(coordinate, aiGrid, out aiGrid, out boatWasHit, out boatWasSunk);
    if (shotAlready == true)
    {
        Console.WriteLine("You stupid fuckin moron pick another");
    }
}

if (boatWasSunk == true)
{
    // TODO: tell the user which battleship they sunk
    Console.WriteLine("YOU SUNK A BATTLESHIP");
}


// print grid after Fire
BattleshipsConsole.PrintGrid(aiGrid);

#if DEBUG
    // stop point for debugging purposes
    Console.ReadLine();
#endif







