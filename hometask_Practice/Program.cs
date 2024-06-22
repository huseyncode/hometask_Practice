using System;
using CourseManagement;

namespace MainCourseManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course { Name = "Computer Science" };
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nCourse Management Menu:");
                Console.WriteLine("1. Add Group");
                Console.WriteLine("2. View Groups");
                Console.WriteLine("3. Edit Group");
                Console.WriteLine("4. Remove Group");
                Console.WriteLine("5. Add Student to Group");
                Console.WriteLine("6. View Students in Group");
                Console.WriteLine("7. View All Students");
                Console.WriteLine("8. Search Students");
                Console.WriteLine("9. Remove Student from Group");
                Console.WriteLine("10. Edit Student in Group");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter group name: ");
                        string groupName = Console.ReadLine();
                        Console.Write("Enter group limit: ");
                        int groupLimit = int.Parse(Console.ReadLine());
                        course.AddGroup(groupName, groupLimit);
                        break;

                    case "2":
                        course.DisplayGroups();
                        break;

                    case "3":
                        Console.Write("Enter group name to edit: ");
                        string editGroupName = Console.ReadLine();
                        var groupToEdit = course.GetGroupByName(editGroupName);
                        if (groupToEdit != null)
                        {
                            Console.Write("Enter new group name: ");
                            groupToEdit.Name = Console.ReadLine();
                            Console.Write("Enter new group limit: ");
                            groupToEdit.Limit = int.Parse(Console.ReadLine());
                            Console.WriteLine("Group information updated.");
                        }
                        else
                        {
                            Console.WriteLine("Group not found.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter group name to remove: ");
                        string removeGroupName = Console.ReadLine();
                        course.RemoveGroup(removeGroupName);
                        break;

                    case "5":
                        course.DisplayGroups();
                        Console.Write("Enter group name to add student: ");
                        string addGroupName = Console.ReadLine();
                        var groupToAddStudent = course.GetGroupByName(addGroupName);
                        if (groupToAddStudent != null)
                        {
                            var student = new Student();
                            Console.Write("Enter student name: ");
                            student.Name = Console.ReadLine();
                            Console.Write("Enter student surname: ");
                            student.Surname = Console.ReadLine();
                            Console.Write("Enter student age: ");
                            student.Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter student grade: ");
                            student.Grade = double.Parse(Console.ReadLine());
                            groupToAddStudent.AddStudent(student);
                        }
                        else
                        {
                            Console.WriteLine("Group not found.");
                        }
                        break;

                    case "6":
                        course.DisplayGroups();
                        Console.Write("Enter group name to view students: ");
                        string viewGroupName = Console.ReadLine();
                        var groupToViewStudents = course.GetGroupByName(viewGroupName);
                        if (groupToViewStudents != null)
                        {
                            groupToViewStudents.DisplayStudents();
                        }
                        else
                        {
                            Console.WriteLine("Group not found.");
                        }
                        break;

                    case "7":
                        course.DisplayAllStudents();
                        break;

                    case "8":
                        Console.Write("Enter search string: ");
                        string searchString = Console.ReadLine();
                        var searchResults = course.SearchStudents(searchString);
                        foreach (var student in searchResults)
                        {
                            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, Grade: {student.Grade}");
                        }
                        break;

                    case "9":
                        course.DisplayGroups();
                        Console.Write("Enter group name to remove student: ");
                        string removeStudentGroupName = Console.ReadLine();
                        var groupToRemoveStudent = course.GetGroupByName(removeStudentGroupName);
                        if (groupToRemoveStudent != null)
                        {
                            groupToRemoveStudent.DisplayStudents();
                            Console.Write("Enter student ID to remove: ");
                            int removeStudentId = int.Parse(Console.ReadLine());
                            groupToRemoveStudent.RemoveStudent(removeStudentId);
                        }
                        else
                        {
                            Console.WriteLine("Group not found.");
                        }
                        break;

                    case "10":
                        course.DisplayGroups();
                        Console.Write("Enter group name to edit student: ");
                        string editStudentGroupName = Console.ReadLine();
                        var groupToEditStudent = course.GetGroupByName(editStudentGroupName);
                        if (groupToEditStudent != null)
                        {
                            groupToEditStudent.DisplayStudents();
                            Console.Write("Enter student ID to edit: ");
                            int editStudentId = int.Parse(Console.ReadLine());
                            Console.Write("Enter new student name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter new student surname: ");
                            string newSurname = Console.ReadLine();
                            Console.Write("Enter new student age: ");
                            int newAge = int.Parse(Console.ReadLine());
                            Console.Write("Enter new student grade: ");
                            double newGrade = double.Parse(Console.ReadLine());
                            groupToEditStudent.EditStudent(editStudentId, newName, newSurname, newAge, newGrade);
                        }
                        else
                        {
                            Console.WriteLine("Group not found.");
                        }
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
