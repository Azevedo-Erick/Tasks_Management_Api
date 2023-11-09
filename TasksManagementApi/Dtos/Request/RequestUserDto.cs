namespace TasksManagementApi.Dtos;

public class RequestUserDto
{
    public string Name { get; set; }
    public string Password { get; set; }
    public IFormFile ProfilePicture { get; set; }
}