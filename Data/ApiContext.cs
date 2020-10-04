using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}