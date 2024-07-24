using System.Threading.Channels;

namespace Yagni;

public class Task
{
    public string Name {get; set;}
    public bool IsCompleted {get; set;}

    public Task (string name)
    {
        Name = name;
        IsCompleted = false;
    }

    public void Complete() {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"Tarea: {Name}, Completada: {IsCompleted}";
    }
}
