using Battleships;
using BoardGameEngines;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsEngine.CreateNewGrid();
string[,] aiGrid = BattleshipsEngine.CreateNewGrid();
bool boatWasHit = false;
string boatWasSunk = null;
string boatName = null;
bool allBoatsWereSunk = false;

#if DEBUG
    // FOR TESTING ONLY, SHOULD BE REMOVED LATER
    // add hard coded boats to grid to simulate game
    BattleshipsEngine.MockAddBoatsToGrid(aiGrid);
#endif

// print grid before Fire
BattleshipsConsole.PrintGrid(aiGrid, true);

// initialise shotAlready to enter loop and the coordinate object
bool shotAlready = true;
ArrayCoordinate coordinate = null;

while (shotAlready == true)
{    
    coordinate = BattleshipsConsole.GetCoordinate();
    shotAlready = BattleshipsEngine.Fire(coordinate, aiGrid, out aiGrid, out boatWasHit, out boatWasSunk, out allBoatsWereSunk);
    if (shotAlready == true)
    {
        Console.WriteLine("You stupid fuckin moron pick another");
    }
}

if (boatWasSunk != null)
{
    boatName = BattleshipsConsole.GetNameOfBattleShip(boatWasSunk);
    Console.WriteLine($"YOU SUNK A {boatName.ToUpper()}");
    
    if(allBoatsWereSunk == true)
    {
        Console.WriteLine("YOU WIN!!");
        // TODO: write code to play again, for now end
        return;
    }
}


// print grid after Fire
BattleshipsConsole.PrintGrid(aiGrid);

#if DEBUG
    // stop point for debugging purposes
    Console.ReadLine();
#endif







