using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
   public class Student
    {
        private static int NextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student()
        {
            Id = NextId++;
        }
    }
}
