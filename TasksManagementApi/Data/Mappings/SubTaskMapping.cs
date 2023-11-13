using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksManagementApi.Models;

namespace TasksManagementApi.Data.Mappings;

public class SubTaskMapping :  IEntityTypeConfiguration<SubTask>
{
    public void Configure(EntityTypeBuilder<SubTask> builder)
    {
        builder.ToTable("sub_tasks");


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
        
        builder.Property(e => e.Completed)
            .HasMaxLength(255)
            .HasColumnName("completed");
        
        

    }
}