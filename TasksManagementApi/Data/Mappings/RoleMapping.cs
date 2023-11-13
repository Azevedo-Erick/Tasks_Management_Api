using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksManagementApi.Models;

namespace TasksManagementApi.Data.Mappings;

public class RoleMapping : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");


        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");
        
        builder.Property(x=>x.Name)
            .HasColumnName("name");

    }
}