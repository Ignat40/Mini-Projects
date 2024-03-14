namespace ToDoList.Tests;

using System.Security.Cryptography.X509Certificates;
using Todo;


public class JsonStorageTests
{
    private readonly string _testFilePath = @"test.json";

    [Fact]
    public void LoadList_FileDoesNotExist()
    {
        var storage = new JsonStorage(_testFilePath);

        Assert.Throws<FileNotFoundException>(() => storage.LoadList());
    }

    [Fact]
    public void SaveList_ValidDataSavesToFile()
    {
        var storage = new JsonStorage(_testFilePath);
        var tasks = new List<Task>
        {
            new() {Description = "Task 1", Status = Task.Category.ToDo},
            new() {Description = "Task 2", Status = Task.Category.InProcess}
        };

        storage.SaveList(tasks);

        Assert.True(File.Exists(_testFilePath));

        File.Delete(_testFilePath);

    }

    [Fact]
    public void LoadList_ValidDataReturnsList()
    {
        var storage = new JsonStorage(_testFilePath);
        var tasks = new List<Task>
        {
            new() {Title = "Task ONe", Description = "Task 1", Status = Task.Category.ToDo},
            new() {Title = "Task Two", Description = "Task 2", Status = Task.Category.InProcess}
        };

        storage.SaveList(tasks);

        var loadedTask = storage.LoadList();

        Assert.Equal(tasks.Count, loadedTask.Count);

        foreach(var task in tasks)
        {
            Assert.Contains(task, loadedTask);
        }

        File.Delete(_testFilePath);
    }
}