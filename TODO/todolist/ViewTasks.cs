namespace ToDo
{
    public class ViewTask
    {
        private List<Task> taskList;

        public ViewTask(List<Task> tasks)
        {
            taskList = tasks;
        }

        public void DisplayTasks()
        {
            Console.WriteLine("Task List:");
            foreach (var task in taskList)
            {
                Console.WriteLine($"Task: {task.TaskName}, State: {task.TaskState}");
            }
        }
    }
}