using System.Linq.Expressions;
using System.Text.Json;
namespace Todo;

public class JsonStorage : IStorage
{
    public List<Task> LoadList()
    {
        string jsonString = File.ReadAllText("todo.json");
        try
        {
            if(string.IsNullOrEmpty(jsonString))
            {
                Console.WriteLine("Invalid Paht");
                return [];
            }
                
            List<Task>? tasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
            return tasks ?? [];
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error ->" + ex);
            return [];
        }
        
    }

    public void SaveList(List<Task> tasks)
    {
        string jsonString = JsonSerializer.Serialize(tasks, new JsonSerializerOptions{ WriteIndented = true});
        try
        {
            File.WriteAllText("todo.json", jsonString);
            Console.WriteLine("Task Saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error -> {ex}");
        }
    }
}