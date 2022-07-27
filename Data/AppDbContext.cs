using Microsoft.EntityFrameworkCore;
using dotnet_with_react.Models;

namespace dotnet_with_react.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Note> Notes { get; set; }
    }
}