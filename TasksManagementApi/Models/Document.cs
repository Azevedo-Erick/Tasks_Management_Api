namespace TasksManagementApi.Models;

public class Document
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EDocumentType Type { get; set; }
    public TaskComment TaskComment { get; set; }
    public int TaskCommentId { get; set; }

}