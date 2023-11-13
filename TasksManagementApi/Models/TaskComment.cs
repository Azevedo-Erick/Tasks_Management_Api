namespace TasksManagementApi.Models;

public class TaskComment
{
    public int Id { get; set; }
    public ProjectMember Author { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public List<Document> Attachments { get; set; }
    public TaskComment? ResponseOf { get; set; }
    public int? ResponseOfId { get; set; }

}