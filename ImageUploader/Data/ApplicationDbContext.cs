using ImageUploader.Models;

using Microsoft.EntityFrameworkCore;

namespace ImageUploader.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
    }
}
