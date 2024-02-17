namespace ToDo
{
    public class AddTask
    {
        private List<Task> taskList = new List<Task>();

        public void TakeAndAddTask()
        {
            Console.WriteLine("Enter task you want to add");
            Console.Write("Task: ");
            string taskName = Console.ReadLine();

            Console.WriteLine("Choose State: \n 1. To Do \n 2. Started Doing \n 3. Done");
            Console.Write("State: ");
            string taskState = Console.ReadLine();

            Task newTask = new Task { TaskName = taskName, TaskState = taskState };
            taskList.Add(newTask);

            Console.WriteLine("Task added successfully!");
        }
    }
}