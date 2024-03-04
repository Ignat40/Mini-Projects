using System.Runtime.CompilerServices;

namespace Todo;

public interface ITask
{
    public void AddTask();
    public void ViewTask();
    public void EditTask();
    public void RemoveTask();

    
}