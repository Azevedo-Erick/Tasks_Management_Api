namespace TasksManagementApi.Models;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProjectMember> ProjectMembers { get; set; }
}