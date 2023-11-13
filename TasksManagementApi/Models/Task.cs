namespace TasksManagementApi.Models;

public class Task
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DeadLine { get; set; }
    public List<SubTask> SubTasks { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskStatus Status { get; set; }
    public int StatusId { get; set; }

    public List<ProjectMember> AssignedTo { get; set; }
    public List<Tag> Tags { get; set; }
    

    public Task()
    {
        SubTasks = new List<SubTask>();
    }
}