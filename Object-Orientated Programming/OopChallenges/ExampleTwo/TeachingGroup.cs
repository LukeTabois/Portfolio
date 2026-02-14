using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChallenges.ExampleTwo
{
    internal class TeachingGroup
    {
        public List<Student> Students { get; set; }

        public TeachingGroup(List<Student> students)
        {
            Students = students;
        }

        public Student GetStudent(string nameOfStudent)
        {
            Student student1 = null;         
            
            foreach (Student student in Students)
            {                
                if(student.Name == nameOfStudent)
                {
                    student1 = student;
                    break;
                }
                else
                {
                    throw new Exception($"{nameOfStudent} could not be found");
                }
            }
            return student1;
        }
    }

}
