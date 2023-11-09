namespace TasksManagementApi.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PasswordHash { get; set; }
    public string ProfilePictureFileName { get; set; }
    public List<Team> Teams { get; set; }
}