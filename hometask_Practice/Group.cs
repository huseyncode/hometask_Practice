using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
   public class Group
    {
        private static int NextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        private List<Student> Students { get; set; } = new List<Student>();

        public Group()
        {
            Id = NextId++;
        }

        public void AddStudent(Student student)
        {
            if (Students.Count >= Limit)
            {
                Console.WriteLine("Group limit reached.");
                return;
            }

            if (Students.Any(s => s.Id == student.Id))
            {
                Console.WriteLine("Student with this ID already exists.");
                return;
            }

            Students.Add(student);
            Console.WriteLine("Student added.");
        }

        public void DisplayStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public void RemoveStudent(int studentId)
        {
            var student = Students.FirstOrDefault(s => s.Id == studentId);
            if (student != null)
            {
                Students.Remove(student);
                Console.WriteLine("Student removed.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void EditStudent(int studentId, string name, string surname, int age, double grade)
        {
            var student = Students.FirstOrDefault(s => s.Id == studentId);
            if (student != null)
            {
                student.Name = name;
                student.Surname = surname;
                student.Age = age;
                student.Grade = grade;
                Console.WriteLine("Student information updated.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
