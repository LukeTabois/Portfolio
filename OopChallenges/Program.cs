using OopChallenges.ExampleOne;
using OopChallenges.ExampleTwo;
using System;
using System.Collections.Generic;

namespace OopChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student luke = new Student("Luke");
            luke.LatestTestScore = 20;

            Student jay = new Student("Jay");
            jay.LatestTestScore = 68;

            Student steve = new Student("Steve");
            steve.LatestTestScore = 99;

            Student erica = new Student("Erica");
            erica.LatestTestScore = 1;

            Student dave = new Student("Dave");
            dave.LatestTestScore = 0;

            List<Student> students = new List<Student>() { dave, jay, steve, erica, luke };

            TeachingGroup groupA = new TeachingGroup(students);            

            Console.WriteLine($"{groupA.GetStudent("Dave").Name} is in {nameof(groupA)}");













            /*
                        // create and test bird
                        Animal newBird = new Bird("Parrot", "Polly");
                        Console.WriteLine(newBird.ToString());

                        // how to access memebers of a singular object
                        //Console.WriteLine(newBird.Species);
                        //Console.WriteLine(newBird.Move());
                        //Console.WriteLine(newBird.GetType());

                        // create a new "animal" using the base/parent
                        //Animal newAnimal = new Animal("Dog", "Spike");
                        //Console.WriteLine(newAnimal.ToString());

                        // create a fish
                        Animal newFish = new Fish("Salmon", "Sam", 3);
                        Console.WriteLine(newFish.ToString());

                        // create a mammal
                        Animal newMammal = new Mammal("Chetah", "Charlie", 4);
                        Console.WriteLine(newMammal.ToString());

                        Console.WriteLine();

                        // create a list of animals
                        List<Animal> animals = new List<Animal>();
                        //animals.Add(newAnimal);
                        animals.Add(newMammal);
                        animals.Add(newFish);
                        animals.Add(newBird);

                        // loop through list
                        // demonstration of polymorphism/overrides
                        foreach (Animal animal in animals)
                        {
                            Console.WriteLine(animal.ToString());
                            Console.WriteLine(animal.Move());
                        }

                        Console.WriteLine();

                        // create bird one
                        Animal birdOne = new Bird("Pidgeon", "Jeff");
                        Console.WriteLine(birdOne.ToString());

                        // create bird two
                        Animal birdTwo = new Bird("Pidgeon", "Jeff");
                        Console.WriteLine(birdTwo.ToString());

                        // create bird three
                        Animal birdThree = birdOne;

                        Console.WriteLine("Is bird one and two the same?");

                        if(birdOne.Equals(birdTwo))
                        {
                            Console.WriteLine("These are the same birds");
                        }
                        else
                        {
                            Console.WriteLine("These are different birds");
                        }

                        Console.WriteLine();

                        Console.WriteLine("Is bird one and three the same?");

                        if (birdOne.Equals(birdThree))
                        {
                            Console.WriteLine("These are the same birds");
                        }
                        else
                        {
                            Console.WriteLine("These are different birds");
                        }
            */
        }
    }
}
