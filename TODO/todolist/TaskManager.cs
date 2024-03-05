namespace Todo;

public class TaskManager : ITask
{
    private List<Task>? tasks;
    private IStorage? taskStorage { get; set; }

    public TaskManager(List<Task>? tasks, IStorage taskStorage)
    {
        this.tasks = tasks;
        this.taskStorage = taskStorage;
    }




    public void AddTask()
    {
        Task task1 = new();
        bool flag = false;

        while (!flag)
        {
            Console.WriteLine("Name Your Task!");
            Console.Write("Title: ");
            string? titleInput = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter Description: ");
            Console.Write("Description: ");
            string? descriptionInput = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Choose Task Status: \n[ 1. ToDo, 2. In Progress, 3. Done]");
            Console.Write("Enter Number: ");
            string? statusInput = Console.ReadLine();
            Task.Category category = new();
            switch (statusInput)
            {
                case "1":
                    category = Task.Category.ToDo;
                    break;
                case "2":
                    category = Task.Category.InProcess;
                    break;
                case "3":
                    category = Task.Category.Done;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Task set to -> ToDo");
                    category = Task.Category.ToDo;
                    break;
            }

            if (string.IsNullOrEmpty(titleInput)
            || string.IsNullOrEmpty(descriptionInput)
            || string.IsNullOrEmpty(statusInput))
            {
                Console.WriteLine("Invalid Input. Make sure you don't leave empty input");
                Console.WriteLine("Try again.");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                task1.Title = titleInput;
                task1.Description = descriptionInput;
                task1.Status = category;

                tasks.Add(task1);
                taskStorage.SaveList(tasks);
                flag = true;
            }
        }

    }

    public void ViewTask()
    {

        Console.WriteLine("How Do You Want To See You Tasks?");
        Console.WriteLine("1. All tasks");
        Console.WriteLine("2. By Category");
        Console.WriteLine("Enter Number: ");
        string? usrInput = Console.ReadLine();
        Console.Clear();

        if (!string.IsNullOrEmpty(usrInput))
        {
            switch (usrInput)
            {
                case "1":
                    ViewAllTasks();
                    break;
                case "2":
                    ViewTaskByCategory();
                    break;
                default:
                    Console.WriteLine("Invalid Input... Try again.");
                    break;
            }
        }

    }

    public void ViewTaskByCategory()
    {
        Console.WriteLine("Choose category:");
        Console.WriteLine("1. To Do");
        Console.WriteLine("2. In Process");
        Console.WriteLine("3. Done");
        Console.Write("Enter Number: ");
        string? usrInput = Console.ReadLine();

        tasks = taskStorage.LoadList();

        if (tasks.Count == 0)
        {
            Console.WriteLine("You Don't Have Any Tasks!");
        }
        else
        {
            if (int.TryParse(usrInput, out int categoryNumber) && categoryNumber >= 1 && categoryNumber <= 3)
            {
                Task.Category selectedCategory = (Task.Category)(categoryNumber - 1);

                Console.WriteLine($"Tasks in {selectedCategory}:");

                Console.WriteLine("======================");
                Console.WriteLine("= Your List Of Tasks =");
                Console.WriteLine("======================");

                foreach (var task in tasks)
                {
                    if (task.Status == selectedCategory)
                    {
                        Console.WriteLine($"Title: {task.Title}");
                        Console.WriteLine($"Status: {task.Status}");
                        Console.WriteLine($"     -: {task.Description}");
                        Console.WriteLine();
                    }
                }

            }
        }


    }

    public void ViewAllTasks()
    {
        Console.WriteLine("======================");
        Console.WriteLine("= Your List Of Tasks =");
        Console.WriteLine("======================");

        tasks = taskStorage.LoadList();

        if (tasks.Count == 0)
        {
            Console.WriteLine("You Don't Have Any Tasks!");
        }
        else
        {

            foreach (var task in tasks)
            {
                Console.WriteLine($"Title: {task.Title}");
                Console.WriteLine($"Status: {task.Status}");
                Console.WriteLine($"     -: {task.Description}");
                Console.WriteLine();
            }
        }
    }

    public void EditTask()
    {
        Console.WriteLine($"You have {tasks.Count} tasks. Which one do you want to edit? ");

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. - {tasks[i].Title}");
        }

        string? usrInput = Console.ReadLine();

        if (int.TryParse(usrInput, out int num))
        {
            num -= 1;
            if (num > tasks.Count)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                tasks.RemoveAt(num);
                AddTask();
                //try to add the task on the place of the removed one!
            }
        }
        else
        {
            Console.WriteLine("Invliad Input...");
        }

    }

    public void RemoveTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("You have no tasks to remove!");
        }
        else
        {
            Console.WriteLine($"You have {tasks.Count} tasks. Which one do you want to remove? ");


            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. - {tasks[i].Title}");
            }

            Console.Write("Enter number: ");
            string? usrInput = Console.ReadLine();

            if (int.TryParse(usrInput, out int num))
            {
                num -= 1;
                if (num >= 0 && num < tasks.Count)
                {
                    tasks.RemoveAt(num);
                    taskStorage.SaveList(tasks);
                    Console.WriteLine("Task Removed Successfully");

                }
                else
                    Console.WriteLine("Invalid input!");
            }
        }

    }

}