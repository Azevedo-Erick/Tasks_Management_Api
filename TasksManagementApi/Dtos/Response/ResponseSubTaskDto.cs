using TasksManagementApi.Models;

namespace TasksManagementApi.Dtos.Response;

public class ResponseSubTaskDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DeadLine { get; set; }
    public TaskPriority Priority { get; set; }
    public StatusTask Status { get; set; }
    public int TaskId { get; set; }
    
}