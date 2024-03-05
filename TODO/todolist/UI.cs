namespace Todo;

public class UI
{
    public static void ProgramLogic()
    {
        Console.WriteLine("=================");
        Console.WriteLine("= You ToDo List =");
        Console.WriteLine("=================");

        bool flag = false;
        List<Task> t = [];
        IStorage storage = new JsonStorage();
        TaskManager taskManager = new(t, storage);

        while (!flag)
        {
            Console.WriteLine("What Would You Like To Do?");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Edit Task");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. Exit");

            Console.Write("Your choice: ");
            string? usrInput = Console.ReadLine();
            
            Console.Clear();

            switch(usrInput)
            {
                case "1":
                    taskManager.ViewTask();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    taskManager.AddTask();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    taskManager.EditTask();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    taskManager.RemoveTask();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    flag = true;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid Input... Try agian!");
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

    }
}