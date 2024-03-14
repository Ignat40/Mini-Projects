namespace Todo;

public class Task
{

    public enum Category
    {
        ToDo,
        InProcess,
        Done
    }


    public Guid TaskId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Category Status { get; set; }

    public Task(Guid taskId, string title, string description, Category status)
    {
        TaskId = taskId;
        Title = title;
        Description = description;
        Status = status;
    }

    public Task()
    {
        TaskId = Guid.NewGuid();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Task other = (Task)obj;
        return TaskId.Equals(other.TaskId) &&
               Title == other.Title &&
               Description == other.Description &&
               Status == other.Status;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(TaskId, Title, Description, Status);
    }

}