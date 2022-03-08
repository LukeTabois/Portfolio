using CodingChallenges;

Console.WriteLine("===========================");
Console.WriteLine("           LEVEL 1         ");
Console.WriteLine("===========================");

//Console.WriteLine("1. Given two strings, firstName and lastName, return a single string in the format last, first.");

//// ANSWER HERE...
//// initalise first name from user input
//Console.WriteLine("Please enter your first name");
//string firstName = Console.ReadLine();

//// initalise last name from user input
//Console.WriteLine("Please enter your last name");
//string lastName = Console.ReadLine();

//// initalise full name from first and last using print full name method
//string fullName = CodeChallengeMethod.PrintFullName(firstName, lastName);

//// print full name
//Console.WriteLine($"The full name is {fullName}");

//Console.WriteLine("---------------------------");

//Console.WriteLine("2. Create a function that returns true if a string contains any spaces.");

//// ANSWER HERE...
//Console.WriteLine();
//// initialise text to check from user input
//Console.WriteLine("Enter text you wish to check");
//string textToCheck = Console.ReadLine();

//// intialise is there a space from space checker method
//bool isThereASpace = CodeChallengeMethod.SpaceChecker(textToCheck);

//// print is there a space
//Console.WriteLine(isThereASpace);

//Console.WriteLine("---------------------------");


//Console.WriteLine("3. Write a function that takes an integer minutes and converts it to seconds.");

//// ANSWER HERE...
//// intialise number to check from user input
//Console.WriteLine("Please enter the number you wish to convert into seconds");
//int numberInMinutes = int.Parse(Console.ReadLine());

////int numberToCheckTwo = Convert.ToInt32(Console.ReadLine());

//// initialise result from second convertor method checking number in minutes
//int resultInSeconds = CodeChallengeMethod.SecondConvertor(numberInMinutes);

//// print result to user
//Console.WriteLine($"{numberInMinutes} in seconds is {resultInSeconds}");

//Console.WriteLine("---------------------------");

//Console.WriteLine("4. Create a function that takes a string and returns it as an integer.");

//// ANSWER HERE...
////TODO: work out validation of string to int maybe try parse?
//Console.WriteLine("Please enter the text to convert to int");
//string userInput = Console.ReadLine();

//int userInputAsInt = CodeChallengeMethod.StringToInt(userInput);

//Console.WriteLine($"text is now set as type {userInputAsInt.GetType()}");

//Console.WriteLine("---------------------------");


//Console.WriteLine("5. Write a function that takes 2 lengths of a rectangle and returns if it is a square, its area and its perimeter");

//// ANSWER HERE...
//int area = -1;
//int perimeter = -1;

//// initilise first length from user input
//Console.WriteLine("Please enter the first length");
//int firstLength = int.Parse(Console.ReadLine());

//Console.WriteLine();

//// initilise second length from user input
//Console.WriteLine("Please enter the second length");
//int secondLength = int.Parse(Console.ReadLine());

//// intialise answer from first and second lenght then apply method 
//bool isSquare = CodeChallengeMethod.GetRectangleInfo(firstLength, secondLength, out area, out perimeter);
//Console.WriteLine();
//// print the answer
//if(isSquare == true)
//{
//    Console.WriteLine("The shape is a square");
//}
//else
//{
//    Console.WriteLine("The shape is a rectangle");
//}
//Console.WriteLine();
//Console.WriteLine($"The area of the shape {area}");
//Console.WriteLine();
//Console.WriteLine($"The perimeter of the shape {perimeter}");


//Console.WriteLine("---------------------------");


//Console.WriteLine("6. Create a function that returns true when num1 is equal to num2; otherwise return false.");

//// ANSWER HERE...
//Console.WriteLine();
//Console.WriteLine("please enter the first number");
//int firstNumber = int.Parse(Console.ReadLine());

//Console.WriteLine();

//Console.WriteLine("please enter the second number");
//int secondNumber = int.Parse(Console.ReadLine());

//bool areTheyEqual = CodeChallengeMethod.AreTheyEqual(firstNumber, secondNumber);

//Console.WriteLine($"The answer to if the numbers are equal to each other is {areTheyEqual}");

//Console.WriteLine("---------------------------");

//Console.WriteLine("7. Create a function that takes a number and returns the day of the week");
//// ANSWER HERE...
//Console.WriteLine();
//Console.WriteLine("Please enter the day of the week in number format");
//Console.WriteLine();
//int dayOfTheWeek = int.Parse(Console.ReadLine());

//string weekDay = CodeChallengeMethod.DaysOfTheWeek(dayOfTheWeek);

//Console.WriteLine($"The day would be a {weekDay}");
//Console.WriteLine();

//Console.WriteLine("---------------------------");


//Console.WriteLine("8. Create a function that takes a string array of names and returns the first element.");

//// ANSWER HERE...
//string[] names = { "Steve", "Luke", "Bill", "Fred" };
//Console.WriteLine();
//Console.WriteLine(CodeChallengeMethod.GetFirstElementOfArray(names));


//Console.WriteLine("---------------------------");

//Console.WriteLine("9. Create a function that takes 2 numbers and prints every even number between the 2.");

//// ANSWER HERE...
//Console.WriteLine();
//Console.WriteLine("Please enter the first number");
//int qNineFirstNumber = int.Parse(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine("Please enter the second number");
//int qNineSecondNumber = int.Parse(Console.ReadLine());
//Console.WriteLine();

//CodeChallengeMethod.GetEvenNumbers(qNineFirstNumber, qNineSecondNumber);


//Console.WriteLine("---------------------------");


//Console.WriteLine("10. Create a function that takes an array of integers and returns the total.");

//// ANSWER HERE...
//int[] numbers = { 2, 5, 3, 1 }; // 11 in total

//Console.WriteLine();
//Console.WriteLine(CodeChallengeMethod.TotalOfArray(numbers));

//Console.WriteLine("---------------------------");

//Console.WriteLine("11.  Create a function that takes an array and a string as arguments and returns the index of the string.");

//// ANSWER HERE...
//string[] boats = { "Carrier", "Battleship", "Submarine", "Patrol Boat", "Destroyer" };
//string boatToFind = "Submarine";

//Console.WriteLine(CodeChallengeMethod.GetIndexOf(boats, boatToFind));

Console.WriteLine("---------------------------");

Console.WriteLine("===========================");
Console.WriteLine("           LEVEL 2         ");
Console.WriteLine("===========================");

//Console.WriteLine("1. Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.");

//// ANSWER HERE...
//// intilise text to convert by user input
//string textToConvert = Console.ReadLine();

//// set value of text to convert to method outcome
//textToConvert = CodeChallengeMethod.HackerSpeak(textToConvert);

//// print converted text
//Console.WriteLine();
//Console.WriteLine(textToConvert);
//Console.WriteLine();

//Console.WriteLine("---------------------------");

//Console.WriteLine($"2. Create a function that takes a number as an argument and returns Fizz, Buzz or FizzBuzz.");

//// If the number is a multiple of 3 the output should be "Fizz".
//// If the number given is a multiple of 5, the output should be "Buzz".
//// If the number given is a multiple of both 3 and 5, the output should be "FizzBuzz".
//// If the number is not a multiple of either 3 or 5, the number should be output on its own as shown in the examples below.
//// The output should always be a string even if it is not a multiple of 3 or 5.

//// ANSWER HERE...
//// code was taken off of a website while researching, Luke will justify the use of it to Steve ;)
//Console.WriteLine();
//int numberToCheck = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();
//CodeChallengeMethod.FizzBuzz(numberToCheck);

//Console.WriteLine("---------------------------");

//Console.WriteLine($"3. Create a function that counts how many D's are in a sentence.");

//// ANSWER HERE...
//string sentenceToCheck = "doing this test Does wonders";

//Console.WriteLine(CodeChallengeMethod.CountDs(sentenceToCheck));

//Console.WriteLine("---------------------------");

//Console.WriteLine($"4. Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.");

//// ANSWER HERE...
//int[] numbers = { 1, 5, 3, 8, 2 };

//int[] minMax = CodeChallengeMethod.FindMinMax(numbers);

//Console.WriteLine($"{minMax[0]}, {minMax[1]}");

Console.WriteLine("---------------------------");

Console.WriteLine($"5. Create a function that takes an array of numbers and returns the mean (average) of all those numbers.");

// ANSWER HERE...

int[] numbersToMean = { 1, 5, 8, 2, 10 };

decimal mean = CodeChallengeMethod.Mean(numbersToMean);

Console.WriteLine();
Console.WriteLine(mean);








