using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksManagementApi.Models;
namespace TasksManagementApi.Data.Mappings;

public class TeamMapping : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("teams");


        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        
        builder.Property(e => e.Description)
            .HasMaxLength(255)
            .HasColumnName("description");

      


    }
}