namespace ToDo
{
    class Program
    {
        static void Main()
        {
            List<Task> tasks = new List<Task>();  // List to store tasks

            AddTask addTask = new AddTask();
            ViewTask viewTask = new ViewTask(tasks);

            while (true)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addTask.TakeAndAddTask();
                        break;
                    case "2":
                        viewTask.DisplayTasks();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}