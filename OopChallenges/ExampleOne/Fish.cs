using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChallenges.ExampleOne
{
    internal class Fish : Animal
    {
        public int NumberOfFins { get; set; }

        public Fish(string species, string name, int numberOfFins) : base(species, name)
        {
            NumberOfFins = numberOfFins;
        }

        public override string Move()
        {
            return $"{Name} is swimming";
        }
    }
}
