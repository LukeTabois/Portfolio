using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChallenges.ExampleOne
{
    internal class Mammal : Animal
    {
        public int NumberOfLegs { get; set; }

        public Mammal(string species, string name, int numberOfLegs) : base(species, name)
        {
            NumberOfLegs = numberOfLegs;
        }

        public override string Move()
        {
            return $"{Name} is running";
        }

    }
}
