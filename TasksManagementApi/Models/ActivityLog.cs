namespace TasksManagementApi.Models;

public class ActivityLog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public EActivityLogType Type { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public DateTime Timestamp { get; set; } 
}