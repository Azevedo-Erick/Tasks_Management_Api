namespace TasksManagementApi.Models;

public class ProjectMember
{
    public int Id { get; set; }
    public Project Project { get; set; }
    public int ProjectId  { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public Role Role { get; set; }
    public int RoleId { get; set; }
    public List<Task> Tasks { get; set; }
    public List<TaskComment> Comments { get; set; }
}