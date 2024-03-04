namespace Todo;

public class TaskManager : ITask
{
    private List<Task>? tasks;
    private IStorage? taskStorage;


    public void AddTask()
    {
        Console.WriteLine("Enter Task Title: ");
        Console.Write("You input: ");
        string? titleInput = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Enter Description: ");
        Console.Write("You input: ");
        string? descriptionInput = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Enter Task Status: \n[ 1. ToDo, 2. In Progress, 3. Done]");
        Console.Write("Enter Number: ");
        string? statusInput = Console.ReadLine();
        Task.Category category;
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

        }
        Console.Clear();

        if (!(string.IsNullOrEmpty(titleInput)
        && string.IsNullOrEmpty(descriptionInput) 
        && string.IsNullOrEmpty(statusInput)))
        {
            var task = new(titleInput, descriptionInput, category);
        }



    }

}