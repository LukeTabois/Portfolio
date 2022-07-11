using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChallenges.ExampleTwo
{
    internal class Student
    {
        public string Name { get; set; }

        private int latestTestScore;

        public int LatestTestScore
        {
            get { return latestTestScore; }
            set 
            { 
                if(value >= 0 && value <= 100 )
                {
                    latestTestScore = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(latestTestScore),"test score needs to be within 0 and 100");
                }
            }
        }


        public Student(string name)
        {
            Name = name;
        }


    }
}
