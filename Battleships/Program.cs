using Battleships;
using BoardGameEngines;

// initialise grids for player and AI
string[,] playerGrid = BattleshipsEngine.CreateNewGrid();
string[,] aiGrid = BattleshipsEngine.CreateNewGrid();

// initialise boat name for place boat and fire
string boatName = null;

#if DEBUG
    // FOR TESTING ONLY, SHOULD BE REMOVED LATER
    // add hard coded boats to grid to simulate game
    // BattleshipsEngine.MockAddBoatsToGrid(aiGrid);
#endif

// print grid before
BattleshipsConsole.PrintGrid(playerGrid, true);
Console.WriteLine();

// intialising variables for place ship
ArrayCoordinate startCoordinate = null;
ArrayCoordinate endCoordinate = null;
string boatLetter = null;
bool isBoatPlacementValid = false;

// get basic inputs for place ship
Console.WriteLine("Enter a Boat Letter");
boatLetter = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("(start coordinate)");
startCoordinate = BattleshipsConsole.GetCoordinate();

Console.WriteLine("(end coordinate)");
endCoordinate = BattleshipsConsole.GetCoordinate();

// call place ship passing inputs
isBoatPlacementValid = BattleshipsEngine.PlaceShip(playerGrid, startCoordinate, endCoordinate, boatLetter, out playerGrid);

if (isBoatPlacementValid == false)
{// TODO: make the error nicer
    Console.WriteLine("Boat placement was not valid");
}
// print grid before
BattleshipsConsole.PrintGrid(playerGrid, true);
Console.WriteLine();

// FOR TESTING ONLY, SHOULD BE REMOVED LATER
return;








// initialise variables for fire
string boatWasHit = null;
string boatWasSunk = null;
bool allBoatsWereSunk = false;
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







