using CodingChallenges;

bool quit = false;

while (quit == false)
{
    Console.WriteLine("Please enter a level");
    string level = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Please enter a question number");
    string questionNumber = Console.ReadLine();
    Console.WriteLine();

    switch (level)
    {
        // level 1
        case "1":
            {
                switch (questionNumber)
                {
                    // l1 q1
                    case "1":
                        {
                            Console.WriteLine("L1 Q1 - Given two strings, firstName and lastName, return a single string in the format last, first.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter your first name");
                            string firstName = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Please enter your last name");
                            string lastName = Console.ReadLine();
                            Console.WriteLine();

                            string fullName = CodeChallengeMethod.PrintFullName(firstName, lastName);
                            Console.WriteLine($"The full name is {fullName}");
                        }
                        break;
                    // l1 q2
                    case "2":
                        {
                            Console.WriteLine("L1 Q2 - Create a function that returns true if a string contains any spaces.");
                            Console.WriteLine();

                            Console.WriteLine("Enter text you wish to check");
                            string textToCheck = Console.ReadLine();
                            Console.WriteLine();

                            bool isThereASpace = CodeChallengeMethod.SpaceChecker(textToCheck);
                            Console.WriteLine(isThereASpace);
                        }
                        break;
                    // l1 q3
                    case "3":
                        {
                            Console.WriteLine("L1 Q3 - Write a function that takes an integer minutes and converts it to seconds.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the number you wish to convert into seconds");
                            int numberInMinutes = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            int resultInSeconds = CodeChallengeMethod.SecondConvertor(numberInMinutes);
                            Console.WriteLine($"{numberInMinutes} in seconds is {resultInSeconds}");
                        }
                        break;
                    // l1 q4
                    case "4":
                        {
                            Console.WriteLine("L1 Q4 - Create a function that takes a string and returns it as an integer.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the text to convert to int");
                            string userInput = Console.ReadLine();
                            Console.WriteLine();

                            int userInputAsInt = CodeChallengeMethod.StringToInt(userInput);
                            Console.WriteLine($"text is now set as type {userInputAsInt.GetType()}");
                        }
                        break;
                    // l1 q5
                    case "5":
                        {
                            Console.WriteLine("L1 Q5 - Write a function that takes 2 lengths of a rectangle and returns if it is a square, its area and its perimeter");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the first length");
                            int firstLength = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Please enter the second length");
                            int secondLength = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            bool isSquare = CodeChallengeMethod.GetRectangleInfo(firstLength, secondLength, out int area, out int perimeter);
                            Console.WriteLine();

                            if (isSquare == true)
                            {
                                Console.WriteLine("The shape is a square");
                            }
                            else
                            {
                                Console.WriteLine("The shape is a rectangle");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"The area of the shape {area}");
                            Console.WriteLine();
                            Console.WriteLine($"The perimeter of the shape {perimeter}");
                        }
                        break;
                    // l1 q6
                    case "6":
                        {
                            Console.WriteLine("L1 Q6 - Create a function that returns true when num1 is equal to num2; otherwise return false.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the first number");
                            int firstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Please enter the second number");
                            int secondNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            bool areTheyEqual = CodeChallengeMethod.AreTheyEqual(firstNumber, secondNumber);
                            Console.WriteLine($"The answer to if the numbers are equal to each other is {areTheyEqual}");
                        }
                        break;
                    // l1 q7
                    case "7":
                        {
                            Console.WriteLine("L1 Q7 - Create a function that takes a number and returns the day of the week");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the day of the week in number format");
                            int dayOfTheWeek = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            string weekDay = CodeChallengeMethod.DaysOfTheWeek(dayOfTheWeek);
                            Console.WriteLine($"The day would be a {weekDay}");
                        }
                        break;
                    // l1 q8
                    case "8":
                        {
                            Console.WriteLine("L1 Q8 - Create a function that takes a string array of names and returns the first element.");
                            Console.WriteLine();

                            string[] names = { "Steve", "Luke", "Bill", "Fred" };
                            Console.WriteLine(CodeChallengeMethod.GetFirstElementOfArray(names));
                        }
                        break;
                    // l1 q9
                    case "9":
                        {
                            Console.WriteLine("L1 Q9 - Create a function that takes 2 numbers and prints every even number between the 2.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter the first number");
                            int qNineFirstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Please enter the second number");
                            int qNineSecondNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            CodeChallengeMethod.GetEvenNumbers(qNineFirstNumber, qNineSecondNumber);
                        }
                        break;
                    // l1 q10
                    case "10":
                        {
                            Console.WriteLine("L1 Q10 - Create a function that takes an array of integers and returns the total.");
                            Console.WriteLine();

                            int[] q10Numbers = { 2, 5, 3, 1 }; // 11 in total
                            Console.WriteLine(CodeChallengeMethod.TotalOfArray(q10Numbers));
                        }
                        break;
                    // l1 q11
                    case "11":
                        {
                            Console.WriteLine("L1 Q11 - Create a function that takes an array and a string as arguments and returns the index of the string.");
                            Console.WriteLine();

                            string[] boats = { "Carrier", "Battleship", "Submarine", "Patrol Boat", "Destroyer" };
                            string boatToFind = "Submarine";

                            Console.WriteLine(CodeChallengeMethod.GetIndexOf(boats, boatToFind));
                        }
                        break;
                    default:
                        Console.WriteLine("Question entered was not valid");
                        break;
                }
            }
            break;
        // level 2
        case "2":
            {
                switch (questionNumber)
                {
                    // l2 q1
                    case "1":
                        {
                            Console.WriteLine("L2 Q1 - Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter text to convert to hacker speak");
                            string textToConvert = Console.ReadLine();
                            Console.WriteLine();

                            textToConvert = CodeChallengeMethod.HackerSpeak(textToConvert);
                            Console.WriteLine(textToConvert);
                        }
                        break;
                    // l2 q2
                    case "2":
                        {
                            Console.WriteLine($"L2 Q2 - Create a function that takes a number as an argument and returns Fizz, Buzz or FizzBuzz.");
                            // If the number is a multiple of 3 the output should be "Fizz".
                            // If the number given is a multiple of 5, the output should be "Buzz".
                            // If the number given is a multiple of both 3 and 5, the output should be "FizzBuzz".
                            // If the number is not a multiple of either 3 or 5, the number should be output on its own as shown in the examples below.
                            // The output should always be a string even if it is not a multiple of 3 or 5.
                            Console.WriteLine();

                            Console.WriteLine("Please enter a number to check");
                            int numberToCheck = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            CodeChallengeMethod.FizzBuzz(numberToCheck);
                        }
                        break;
                    // l2 q3
                    case "3":
                        {
                            Console.WriteLine($"L2 Q3 - Create a function that counts how many D's are in a sentence.");
                            Console.WriteLine();

                            Console.WriteLine("Please enter a sentence to check");
                            string sentenceToCheck = Console.ReadLine();
                            Console.WriteLine(CodeChallengeMethod.CountDs(sentenceToCheck));
                        }
                        break;
                    // l2 q4
                    case "4":
                        {
                            Console.WriteLine($"L2 Q4 - Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.");
                            Console.WriteLine();

                            int[] numbers = { 1, 5, 3, 8, 2 };
                            int[] minMax = CodeChallengeMethod.FindMinMax(numbers);

                            Console.WriteLine($"{minMax[0]}, {minMax[1]}");
                        }
                        break;
                    // l2 q5
                    case "5":
                        {
                            Console.WriteLine($"L2 Q5 - Create a function that takes an array of numbers and returns the mean (average) of all those numbers.");
                            Console.WriteLine();

                            int[] numbersToMean = { 1, 5, 8, 2, 10 };
                            decimal mean = CodeChallengeMethod.Mean(numbersToMean);
                            Console.WriteLine(mean);
                        }
                        break;
                    // l2 q6
                    case "6":
                        {
                            int isNumberPrime = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(CodeChallengeMethod.IsPrime(isNumberPrime));
                        }
                        break;
                    // l2 q7
                    case "7":
                        {
                            Console.WriteLine("How many imposters?");
                            int imposters = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("How many players?");
                            int players = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("The chance of being an imposter is..");
                            Console.WriteLine($"{CodeChallengeMethod.ImposterFormula(imposters, players)}%");
                        }
                        break;
                    // l2 q8
                    case "8":
                        {

                        }
                        break;
                    // l2 q9
                    case "9":
                        {

                        }
                        break;
                    // l2 q10
                    case "10":
                        {

                        }
                        break;
                    // l2 q11
                    case "11":
                        {

                        }
                        break;
                    default:
                        Console.WriteLine("Question entered was not valid");
                        break;
                }
            }
            break;
        default:
            Console.WriteLine("Level entered was not valid");
            break;
    }
    Console.WriteLine();

    Console.WriteLine("Would you like to quit? (y/n)");
    string answer = Console.ReadLine().ToLower();
    if (answer == "y")
    {
        quit = true;
    }
    Console.WriteLine();
}
