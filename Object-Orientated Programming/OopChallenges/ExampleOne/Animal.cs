using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChallenges.ExampleOne
{
    internal abstract class Animal
    {
        public string Species { get; set; }

        public string Name { get; set; }

        public Animal(string species, string name)
        {
            Species = species;

            Name = name;
        }

        public abstract string Move();        

        public override string ToString()
        {
            return $"This is {Name} the {Species} who is a {this.GetType().Name}";
        }

        public override bool Equals(object obj)
        {
            // converting (casting) obj parameter to an Animal
            Animal animal = obj as Animal;
            
            // if obj is not an animal then false
            if(animal == null)
            {
                return false;
            }
            
            // check if species name and type are the same
            if (animal.Species == this.Species && animal.Name == this.Name && animal.GetType() == this.GetType())
            {
                return true;
            }
            return false;
        }

    }
}
