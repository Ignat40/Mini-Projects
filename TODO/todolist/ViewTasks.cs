namespace ToDo
{
    public class View
    {
        protected List<string> TodoTasks = new();
        protected List<string> Started = new();
        protected List<string> Done = new();

        public void List()
        {
            Console.WriteLine("Enter List To Be Displayed: \n 1. To Do \n 2. Started Doing \n 3. Done");
            Console.Write("Your choice: ");
            string? displayChoice = Console.ReadLine();

            if (displayChoice != null)
            {
                switch (displayChoice)
                {
                    case "1":
                        DisplayLists(TodoTasks);
                        break;
                    case "2":
                        DisplayLists(Started);
                        break;
                    case "3":
                        DisplayLists(Done);
                        break;
                    default:
                        break;
                }
            }
        }

        private void DisplayLists(List<string> list)
        {
            if (list.Count == 0)
                Console.WriteLine("List is empty. Enjoy your day!");
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }
            }

        }

    }


}