using LenaForm.Data.Entities;
using LenaForm.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LenaForm.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Field> Fields { get; set; }
        public DbSet<Form> Forms { get; set; }
    }
}
