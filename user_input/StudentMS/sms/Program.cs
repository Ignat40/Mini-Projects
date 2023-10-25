using System;
using System.Reflection.Metadata;

namespace StudentManageMentSystem
{
    enum Grades
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    struct Student
    {
        public string Name;
        public int Age;
        public Grades Grade;
    }
    public class Program
    {
        /// <summary>
        /// Create a simple student management
        /// system using C# that utilizes
        /// enums, structs, loops, and functions.
        /// The program should allow users to add 
        /// student information and display 
        /// a list of students.

        static Student[] studentInfo = new Student[]
        {
            new Student{Name = "Michael Curry", Age = 19, Grade = Grades.A},
            new Student{Name = "Mike Jr.", Age = 21, Grade = Grades.C},
            new Student{Name = "Kevin Washington", Age = 24, Grade = Grades.B},
            new Student{Name = "Stephan Ignatov", Age = 20, Grade = Grades.F},
        };

        public static void Main()
        {


            Console.WriteLine("WELCOME TO OUR SCHOOL!");

            while (true)
            {
                bool exit = false;

                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("1. View Students");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Exit");

                Console.Write("Choice: ");
                string? userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        ListStudent();
                        break;
                    case "2":
                        AddStudent();
                        break;
                    case "3":
                        RemoveStudent();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. Try again...\n");
                        break;
                }

                if (exit)
                    break;

            }


        }

        public static void AddStudent()
        {
            Console.WriteLine("\nEnter name of the student: ");
            string? nameInput = Console.ReadLine();
            Console.WriteLine("\nEnter age of the student: ");
            if (int.TryParse(Console.ReadLine(), out int ageIn))
            {
                int ageInput = ageIn;
                Console.WriteLine("Enter index for grade [1-6]");
                if (int.TryParse(Console.ReadLine(), out int gradeIn))
                {
                    Grades gradeInput = (Grades)gradeIn;
                    Array.Resize(ref studentInfo, studentInfo.Length + 1);
                    studentInfo[^1] = new Student
                    {
                        Name = nameInput,
                        Age = ageIn,
                        Grade = gradeInput
                    };

                    Console.WriteLine("Student added successfully!\n");
                }
            }


        }

        public static void ListStudent()
        {
            for (int i = 0; i < studentInfo.Length; i++)
            {
                Console.WriteLine($"\n{i + 1}. Name: {studentInfo[i].Name}");
                Console.WriteLine($"   Age: {studentInfo[i].Age}");
                Console.WriteLine($"   Grade:{studentInfo[i].Grade}\n");
            }
        }

        public static void RemoveStudent()
        {
            for (int i = 0; i < studentInfo.Length; i++)
            {
                Console.WriteLine($"{i}. {studentInfo[i].Name}");
            }

            Console.WriteLine($"Select index for the student you want to remove");
            if (int.TryParse(Console.ReadLine(), out int usrChoice))
            {
                for (int i = usrChoice; i < studentInfo.Length - 1; i++)
                {
                    studentInfo[i] = studentInfo[i + 1];
                }

                Array.Resize(ref studentInfo, studentInfo.Length - 1);
                Console.WriteLine("\nSuccessfully removed!\n");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
