using Battleships;

// initialise grid for players
string[,] playerOneGrid = BattleshipsConsole.CreateNewGrid();
string[,] aiGrid = BattleshipsConsole.CreateNewGrid();
BattleshipsConsole.AddBoatsToAiGrid(aiGrid);

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

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("                    LET THE BATTLE COMMENCE                   ");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine();

bool allBoatsWereSunk = false;
bool boatWasHit = false;
bool isPlayerTurn = true;

// initilise to AI grid as player one goes first
string[,] gridToShootAt = aiGrid;

// checks that all the boats have not been sunk 
while (allBoatsWereSunk == false)
{
    // fires at the grid 
    boatWasHit = BattleshipsConsole.Fire(gridToShootAt, isPlayerTurn, out gridToShootAt, out allBoatsWereSunk);
    
    if(allBoatsWereSunk == false)
    {
        BattleshipsConsole.PrintGrid(gridToShootAt);
        Console.WriteLine();
    }    

    if(isPlayerTurn == true)
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
    }

    // changes turn (the grid) based on boat being hit or not
    if (boatWasHit == false)
    {       
        // this will handle the AI missing
        if(isPlayerTurn == false)
        {
            isPlayerTurn = true;
            playerOneGrid = gridToShootAt;
            gridToShootAt = aiGrid;
            Console.WriteLine("IT IS PLAYER ONES TURN...");
        }
        // this will handle the player missing
        else
        {
            isPlayerTurn = false;
            aiGrid = gridToShootAt;
            gridToShootAt = playerOneGrid;
            Console.WriteLine("IT IS THE AI'S TURN...");
        }
    }
    else if(allBoatsWereSunk == false)
    {
        Console.WriteLine("TAKE ANOTHER TURN...");
    }
} 



