using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TasksManagementApi.Data.Mappings;

public class TaskMapping :  IEntityTypeConfiguration<Models.Task>
{
    public void Configure(EntityTypeBuilder<Models.Task> builder)
    {
        builder.ToTable("tasks");


        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");

        builder.Property(e => e.Priority)
            .HasMaxLength(255)
            .HasColumnName("priority");
        
        builder.Property(e => e.Description)
            .HasMaxLength(255)
            .HasColumnName("description");
        
        builder.Property(e => e.StartDate)
            .HasMaxLength(255)
            .HasColumnName("start_date");
        
        builder.Property(e => e.DeadLine)
            .HasMaxLength(255)
            .HasColumnName("dead_line");
        
        builder.Property(e => e.Status)
            .HasMaxLength(255)
            .HasColumnName("status");

        builder.HasMany(x => x.SubTasks)
            .WithOne(x => x.Task);
        



    }
}