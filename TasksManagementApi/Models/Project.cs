namespace TasksManagementApi.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProjectMember> Members { get; set; }
}