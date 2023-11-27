using System;
using UniversityStudentManager.Models;

namespace UniversityStudentManager
{
    class Program
    {
        public static void Main()
        {
            Student student1 = new Student(1, "Ionel", 2000);
            Student student2 = new Student(2, "Gigel", 2001);
            Console.WriteLine($"The first student has an id of {student1.GetId()}, a name of {student1.GetName()} and" +
                              $"year of {student1.GetYear()}");
        }
    }
}