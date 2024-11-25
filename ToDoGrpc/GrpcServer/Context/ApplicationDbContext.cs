using GrpcServer.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcServer.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {       
    }

    public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
}
