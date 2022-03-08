using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public static class CodeChallengeMethod
    {
        //===========================
        //         LEVEL 1         
        //===========================

        /// <summary>
        /// takes a person full name and puts it last name, first name
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <returns>last name, first name</returns>
        public static string PrintFullName(string firstName, string lastName)
        {
            string fullName = $"{lastName}, {firstName}";
            return fullName;
        }

        /// <summary>
        /// checks whether text entered contains spaces
        /// </summary>
        /// <param name="textToCheck">text that is checked for spaces</param>
        /// <returns>true is there are spaces in the text</returns>
        public static bool SpaceChecker(string textToCheck)
        {
            if (textToCheck.Contains(" "))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// converts a number from minutes to seconds
        /// </summary>
        /// <param name="convertToSeconds">number in minutes</param>
        /// <returns>number in minutes, in seconds</returns>
        public static int SecondConvertor(int convertToSeconds)
        {
            convertToSeconds = convertToSeconds * 60;
            
            return convertToSeconds;
        }

        
        public static int StringToInt(string textToConvert)
        {
            int number = -1;
            bool success = int.TryParse(textToConvert, out number);
            if(success == false)
            {
                throw new Exception("input was not a valid number");
            }

            return number;
        }

        
        public static bool GetRectangleInfo(int firstLength, int secondLength, out int area, out int perimeter)
        {
            area = -1;
            perimeter = -1;

            area = (firstLength * secondLength);
            perimeter = ((firstLength * 2) + (secondLength * 2));

            if(firstLength == secondLength)
            {
                return true;
            }
            
           return false;
            
        }

        public static bool AreTheyEqual(int firstNumber, int secondNumber)
        {
            if(firstNumber == secondNumber)
            {
                return true;
            }

            return false;

        }

        public static string DaysOfTheWeek(int dayOfTheWeek)
        {
            string weekDay = null;

            switch (dayOfTheWeek)
            {
                case 1:
                    weekDay = "Monday";
                    break;
                case 2:
                    weekDay = "Tuesday";
                    break;
                case 3:
                    weekDay = "Wednesday";
                    break;
                case 4:
                    weekDay = "Thursday";
                    break;
                case 5:
                    weekDay = "Friday";
                    break;
                case 6:
                    weekDay = "Saturday";
                    break;
                case 7:
                    weekDay = "Sunday";
                    break;
                default:
                    throw new Exception("Not a valid day of the week");
                    break;
            }

            return weekDay;
        }

        public static string GetFirstElementOfArray(string[] names)
        {
            return names[0];
        }

        public static void GetEvenNumbers(int firstNumber, int secondNumber)
        {
            while(firstNumber < secondNumber)
            {
                int remainder = firstNumber % 2;
                if (remainder == 0)
                {
                    Console.WriteLine(firstNumber);
                }

                firstNumber++;
            }
            
            //for (int i = firstNumber; i < secondNumber; i++)
            //{                            

            //    int remainder = i % 2;
            //    if (remainder == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            
        }

        public static int TotalOfArray(int[] numbers)
        {
            int total = 0;

            foreach(int number in numbers)
            {
                total = total + number; 
            }            
            
            return total;
        }

        public static int GetIndexOf(string[] inputArray, string thingToFind)
        {
            int index = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == thingToFind)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        //===========================
        //         LEVEL 2         
        //===========================

        public static string HackerSpeak(string example)
        {
            example = example.Replace('a', '4')
                .Replace('e', '3')
                .Replace('i', '1')
                .Replace('o', '0')
                .Replace('s', '5')
                .Replace('A', '4')
                .Replace('E', '3')
                .Replace('I', '1')
                .Replace('O', '0')
                .Replace('S', '5');

            return example;
        }

        public static void FizzBuzz(int numberToCheck)
        {
            if (numberToCheck % 3 == 0 && numberToCheck % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (numberToCheck % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(numberToCheck % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(numberToCheck);                                
            }
            
        }

        public static int CountDs(string sentenceToCheck)
        {
            int numberOfDs = 0;
            char[] sentenceBreakdown = sentenceToCheck.ToCharArray();

            foreach (char letter in sentenceBreakdown)
            {
                if (letter.ToString().ToUpper() == "D")
                {
                    numberOfDs++;                    
                }
            }            

            return numberOfDs;
        }

        public static int[] FindMinMax(int[] numbers)
        {            
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            int[] minMax = {min, max};

            return minMax;
        }

        public static decimal Mean(int[] numbers)
        {
            decimal mean = 0;
            // total of all numbers added together
            decimal total = 0;


            foreach (int number in numbers)
            {
                total = total + number;
            }
            mean = total / numbers.Length;

            return mean;
        }

        public static int IsPrime(int checkPrime)
            // check number against number -minus if there is no remainder then the number is not prime
        {
            
            
            return 0;
        }
    }



    

    




}
