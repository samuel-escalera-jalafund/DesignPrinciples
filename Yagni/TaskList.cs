namespace Yagni;

public class TaskList
{
    private List<Task> tasks;

    public TaskList()
    {
        tasks = new List<Task>();
    }

    public void AddTask(string taskName)
    {
        Task task = new Task(taskName);
        tasks.Add(task);
    }

    public void ShowTasks()
    {
        foreach(var task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}
