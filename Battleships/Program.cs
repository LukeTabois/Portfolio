using Battleships;

// initialise grid for players
string[,] playerOneGrid = BattleshipsConsole.CreateNewGrid();
string[,] aiGrid = BattleshipsConsole.CreateNewGrid();
BattleshipsConsole.AddBoatsToAiGrid(aiGrid);
/*
Console.WriteLine("==============================================================");
Console.WriteLine("                    WELCOME TO BATTLESHIPS                    ");
Console.WriteLine("==============================================================");
Console.WriteLine();

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("                  GET YOUR BOATS INTO POSITION                ");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("LETS PLACE THE PATROL BOAT...(this boat is two long)");
Console.WriteLine();
BattleshipsConsole.PlaceShip(playerOneGrid, "P");
BattleshipsConsole.PrintGrid(playerOneGrid, true);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("LETS PLACE THE DESTROYER...(this boat is three long)");
Console.WriteLine();
BattleshipsConsole.PlaceShip(playerOneGrid, "D");
BattleshipsConsole.PrintGrid(playerOneGrid, true);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("LETS PLACE THE SUBMARINE...(this boat is three long)");
Console.WriteLine();
BattleshipsConsole.PlaceShip(playerOneGrid, "S");
BattleshipsConsole.PrintGrid(playerOneGrid, true);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("LETS PLACE THE BATTLESHIP...(this boat is four long)");
Console.WriteLine();
BattleshipsConsole.PlaceShip(playerOneGrid, "B");
BattleshipsConsole.PrintGrid(playerOneGrid, true);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("LETS PLACE THE CARRIER...(this boat is five long)");
Console.WriteLine();
BattleshipsConsole.PlaceShip(playerOneGrid, "C");
BattleshipsConsole.PrintGrid(playerOneGrid, true);
Console.WriteLine();
Console.WriteLine();
*/
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("                    LET THE BATTLE COMMENCE                   ");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine();

bool allBoatsWereSunk = false;
bool boatWasHit = false;

do
{
    boatWasHit = BattleshipsConsole.Fire(aiGrid, out aiGrid, out allBoatsWereSunk);
    BattleshipsConsole.PrintGrid(aiGrid);
    Console.WriteLine();
} while (boatWasHit == true && allBoatsWereSunk == false);

// TODO: finish turn based logic