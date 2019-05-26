using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}