using Battleships;
using BoardGameEngines;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsEngine.CreateNewGrid();
string[,] aiGrid = BattleshipsEngine.CreateNewGrid();
string boatWasHit = null;
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
        Console.WriteLine();
    }
}

boatName = BattleshipsConsole.GetNameOfBattleShip(boatWasHit);

if (boatWasHit != null)
{
    Console.WriteLine($"YOU HIT A {boatName.ToUpper()}");
    Console.WriteLine();

    if (boatWasSunk != null)
    {

        Console.WriteLine($"YOU SUNK A {boatName.ToUpper()}");
        Console.WriteLine();

        if (allBoatsWereSunk == true)
        {
            Console.WriteLine("YOU WIN!!");
            Console.WriteLine();

            // TODO: write code to play again, for now end
            return;
        }
    }
}




// print grid after Fire
BattleshipsConsole.PrintGrid(aiGrid);

#if DEBUG
    // stop point for debugging purposes
    Console.ReadLine();
#endif







