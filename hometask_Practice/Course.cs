using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseManagement
{
    public class Course
    {
        public string Name { get; set; }
        private List<Group> Groups { get; set; } = new List<Group>();

        public void AddGroup(string name, int limit)
        {
            if (Groups.Any(g => g.Name == name))
            {
                Console.WriteLine("Group with this name already exists.");
                return;
            }
            Groups.Add(new Group { Name = name, Limit = limit });
        }

        public void DisplayGroups()
        {
            foreach (var group in Groups)
            {
                Console.WriteLine($"ID: {group.Id}, Name: {group.Name}, Limit: {group.Limit}");
            }
        }

        public Group GetGroupByName(string name)
        {
            return Groups.FirstOrDefault(g => g.Name == name);
        }

        public void RemoveGroup(string name)
        {
            var group = GetGroupByName(name);
            if (group != null)
            {
                Groups.Remove(group);
                Console.WriteLine("Group removed.");
            }
            else
            {
                Console.WriteLine("Group not found.");
            }
        }

        public void DisplayAllStudents()
        {
            foreach (var group in Groups)
            {
                foreach (var student in group.GetStudents())
                {
                    Console.WriteLine($"Group: {group.Name}, Student: {student.Id} - {student.Name} {student.Surname}");
                }
            }
        }

        public List<Student> SearchStudents(string searchString)
        {
            var results = new List<Student>();
            foreach (var group in Groups)
            {
                results.AddRange(group.GetStudents().Where(s => s.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)));
            }
            return results;
        }
    }

}
