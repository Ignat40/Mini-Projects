using System.Linq.Expressions;
using System.Text.Json;
namespace Todo;

public class JsonStorage(string filePath) : IStorage
{
    private readonly string _filePath = filePath;

    public List<Task> LoadList()
    {
        
        try
        {
            string jsonString = File.ReadAllText(_filePath);
            if (string.IsNullOrEmpty(jsonString))
            {
                throw new FileNotFoundException("File is empty or does not exist.");
            }
            return JsonSerializer.Deserialize<List<Task>>(jsonString) ?? new List<Task>();
        }
        catch (Exception ex)
        {
            throw new System.IO.FileNotFoundException("Error loading tasks from file.", ex);
        }

    }

    public void SaveList(List<Task> tasks)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, jsonString);
            Console.WriteLine("Task Saved!");
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Error saving task to file", ex);
        }
    }
}