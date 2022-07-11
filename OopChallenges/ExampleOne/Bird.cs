using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChallenges.ExampleOne
{
    internal class Bird : Animal
    {
        private bool CanFly { get; set; }
                
        public Bird(string species, string name) : base(species, name)
        {            
            //assumes the bird can fly if not specified
            CanFly = true;
        }

        public Bird(string species, string name, bool canFly) : base(species, name)
        {
            CanFly = canFly;
        }

        public override string Move()
        {
            if(CanFly)
            {
                return $"{Name} is flying";
            }
            else
            {
                return $"{Name} can't fly";
            }
            
        }       
    }

}
