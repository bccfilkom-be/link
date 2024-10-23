using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tree> Trees { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<LinktreeAccess> LinktreeAccesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LinktreeAccess>()
                .HasKey(la => new { la.TreeId, la.UserId });

            modelBuilder.Entity<LinktreeAccess>()
                .HasOne(la => la.Tree)
                .WithMany(t => t.LinktreeAccesses)
                .HasForeignKey(la => la.TreeId);

            modelBuilder.Entity<LinktreeAccess>()
                .HasOne(la => la.User)
                .WithMany(u => u.LinktreeAccesses)
                .HasForeignKey(la => la.UserId);
        }
    }
}