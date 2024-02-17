namespace ToDo
{
    public class AddTask : View
    {
        private string? userTask = string.Empty;
        public void TakeAndDisplay()
        {
            Console.WriteLine("Enter task you want to add");
            Console.Write("Task: ");
            userTask = Console.ReadLine();


            Console.WriteLine("Choose State: \n 1. To Do \n 2. Started Doing \n 3. Done");
            Console.Write("State: ");
            string? taskState = Console.ReadLine();

            if (userTask != null && taskState != null)
            {
                switch (taskState)
                {
                    case "1":
                        AddTaskToList(TodoTasks);
                        Console.WriteLine("Task added successfully!");
                        break;
                    case "2":
                        AddTaskToList(Started);
                        Console.WriteLine("Task added successfully!");
                        break;
                    case "3":
                        AddTaskToList(Done);
                        Console.WriteLine("Task added successfully!");
                        break;
                }
            }
        }

        private void AddTaskToList(List<string> list)
        {
            if (userTask != string.Empty && userTask != null)
                list.Add(userTask);
            else
                Console.WriteLine("Could not add task!");
        }
    }

}