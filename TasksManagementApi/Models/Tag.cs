namespace TasksManagementApi.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string HexadecimalColor { get; set; }
    public List<Task> Tasks { get; set; }

}