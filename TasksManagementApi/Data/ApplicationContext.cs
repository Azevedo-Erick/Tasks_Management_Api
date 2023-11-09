using Microsoft.EntityFrameworkCore;
using TasksManagementApi.Models;
using Task = TasksManagementApi.Models.Task;

namespace TasksManagementApi.Data;

public class ApplicationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=tasks;uid=root;pwd=123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.42-mysql"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Task> Tasks { get; set; }
    public virtual DbSet<SubTask> SubTasks { get; set; }
    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }


}