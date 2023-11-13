namespace TasksManagementApi.Dtos.Response;

public class ResponseTaskGroupedDto
{
    public string GroupName { get; set; }
    public ResponseTaskDto[] Tasks { get; set; }
}