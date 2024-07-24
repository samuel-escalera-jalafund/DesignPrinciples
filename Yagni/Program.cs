namespace Yagni;

public class Program
{
    static void Main() {
        TaskList taskList = new TaskList();
        taskList.AddTask("Hacer la tarea");
        taskList.AddTask("Lavar la ropa");

        Console.WriteLine("Lista de tareas: ");
        taskList.ShowTasks();

        
    }
}
