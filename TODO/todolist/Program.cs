namespace ToDo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("|       To Do List      |");
            Console.WriteLine("-------------------------");

            View view = new();
            AddTask addTask = new();
            addTask.TakeAndDisplay();
            view.List();
        }
    }
}