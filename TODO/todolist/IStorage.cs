namespace Todo;

public interface IStorage
{
    List<Task> LoadList();
    public void SaveList(List<Task> tasks);
}