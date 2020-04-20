using Microsoft.EntityFrameworkCore;
using SperindeApp.API.Models;

namespace SperindeApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Value> Values { get; set; }
    }
}