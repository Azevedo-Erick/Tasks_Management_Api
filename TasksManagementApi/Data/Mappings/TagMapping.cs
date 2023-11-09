using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasksManagementApi.Models;

namespace TasksManagementApi.Data.Mappings;

public class TagMapping : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable("tags");


        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("bigint(20) unsigned")
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(255)
            .HasColumnName("name");
        
        builder.Property(e => e.HexadecimalColor)
            .HasMaxLength(7)
            .HasColumnName("hexadecimal_color");
    }
}