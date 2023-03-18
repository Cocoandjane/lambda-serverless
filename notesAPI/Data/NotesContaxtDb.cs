using Microsoft.EntityFrameworkCore;
using notesAPI.Models;

namespace notesAPI.Data
{
    public class NotesContaxtDb : DbContext
    {
         public NotesContaxtDb(DbContextOptions<NotesContaxtDb> options)
       : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            builder.Entity<User>().ToTable("user");
            builder.Entity<Post>().ToTable("post");
        }

        public DbSet<Post> Posts => Set<Post>();
        public DbSet<User> Users => Set<User>();
    }
}