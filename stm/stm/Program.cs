using System;
using System.Data;
using System.Runtime.InteropServices.Marshalling;

namespace Stm
{

    enum TaskStatus
    {
        ToDo,
        InProgress,
        Completed
    }

    struct TaskInfo
    {
        public string Name;
        public string DueDate;
        public string Description;
        public TaskStatus Status;
    }

    class Program
    {
        static TaskInfo[] taskList = new TaskInfo[]
            {
            new TaskInfo{Name = "CleanDishes", Description = "The sink is full", DueDate = "2023-10-21", Status = TaskStatus.Completed},
            new TaskInfo{Name = "CleanApart", Description = "The apartment is dirty", DueDate = "2023-10-27", Status = TaskStatus.ToDo},
            new TaskInfo{Name = "MathHW", Description = "Do Math Hw", DueDate = "2023-10-28", Status = TaskStatus.InProgress},
            };

        public static void Main()
        {
            ///<summary>
            ///You are building a simple task management application. 
            ///Each task can have a status, and you need to implement functionality to manage tasks. 
            ///Define an enum for task status (Todo, InProgress, Completed). 
            ///Implement the following operations:
            // Add Task: Allow users to add tasks to the task list.
            // List Tasks: Display all tasks along with their statuses.
            // Update Task Status: Allow users to update the status 
            //of a task from Todo to InProgress, and from InProgress to Completed.


            Console.WriteLine("Welcome to Simple Task Manager!\n");

            while (true)
            {

                Console.WriteLine("Choice of actions: ");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Edit Task");
                Console.WriteLine("3. List Tasks");
                Console.WriteLine("4. Exit");

                Console.Write("Input: ");
                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AddTask();
                }
                else if (userInput == "2")
                {
                    EditTask();
                }
                else if (userInput == "3")
                {
                    ListTasks();
                }
                else if (userInput == "4")
                {
                    Console.WriteLine("BYE!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again... \n");
                    continue;
                }


            }

        }

        public static void ListTasks()
        {
            for (int i = 0; i < taskList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Name: {taskList[i].Name}");
                Console.WriteLine($"   Description: {taskList[i].Description}");
                Console.WriteLine($"   Due Date: {taskList[i].DueDate}");
                Console.WriteLine($"   Status: {taskList[i].Status}\n");
            }


        }
        public static void AddTask()
        {
            Console.WriteLine("Name: ");
            string? nameInput = Console.ReadLine();
            Console.WriteLine("Description: ");
            string? descriptionInput = Console.ReadLine();
            Console.WriteLine("Due Date (YYYY-MM-DD): ");
            string? dateInput = Console.ReadLine();
            Console.WriteLine("Satus index (0-ToDo; 1-InProgress; 2-Completed): ");

            if (int.TryParse(Console.ReadLine(), out int statInput)
            && (statInput == 1 || statInput == 2 || statInput == 3))
            {
                TaskStatus statusInput = (TaskStatus)statInput;

                Array.Resize(ref taskList, taskList.Length + 1);
                taskList[^1] = new TaskInfo
                {
                    Name = nameInput,
                    Description = descriptionInput,
                    DueDate = dateInput,
                    Status = statusInput
                };
            }
            else
            {
                Console.WriteLine("Invalid Status. Try again. ");
            }
        }
        public static void EditTask()
        {
            Console.WriteLine("Select Item to Update Status (Enter index): \n");
            for (int i = 0; i < taskList.Length; i++)
            {
                Console.WriteLine($"{i}. {taskList[i].Name}");
            }

            Console.Write("\nChoice: ");
            if (int.TryParse(Console.ReadLine(), out int inputChoice))
            {
                Console.WriteLine("Enter index for new status (0-ToDo; 1-InProgress; 2-Completed): ");
                if (int.TryParse(Console.ReadLine(), out int newStauts))
                {
                    taskList[inputChoice].Status = (TaskStatus)newStauts;
                    Console.WriteLine("Updated Successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid index. Try agian.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index. Try agian.");
            }
        }
    }
}