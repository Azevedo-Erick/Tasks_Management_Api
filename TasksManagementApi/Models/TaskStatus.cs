namespace TasksManagementApi.Models;

public class TaskStatus
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Task> Tasks { get; set; }

}