using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksManagementApi.Models;

namespace TasksManagementApi.Data.Mappings;

public class TaskCommentMapping : IEntityTypeConfiguration<TaskComment>
{
    public void Configure(EntityTypeBuilder<TaskComment> builder)
    {
        builder.ToTable("task_comments");


        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");
        
        builder.HasMany(x => x.Attachments)
            .WithOne(x => x.TaskComment);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.Comments);

        builder.HasOne(x => x.ResponseOf);
    }
}