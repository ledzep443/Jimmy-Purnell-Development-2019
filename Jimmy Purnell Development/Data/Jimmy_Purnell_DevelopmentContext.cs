using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jimmy_Purnell_Development.Models;

namespace Jimmy_Purnell_Development.Data
{
    public class Jimmy_Purnell_DevelopmentContext : DbContext
    {
        public Jimmy_Purnell_DevelopmentContext (DbContextOptions<Jimmy_Purnell_DevelopmentContext> options)
            : base(options)
        {
        }
        public DbSet<Jimmy_Purnell_Development.Models.Blog> Blog { get; set; }
        public DbSet<Jimmy_Purnell_Development.Models.BlogComments> BlogComments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // configures one-to-many relationship
            modelBuilder.Entity<Blog>()
                .HasMany(BlogComments)
                .HasForeignKey<int>(s => s.BlogCommentsId);
        }
    }

}
}
