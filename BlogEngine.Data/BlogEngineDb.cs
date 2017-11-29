using BlogEngine.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Data
{
    public class BlogEngineDb : DbContext
    {
        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCatagory> BlogCatagories { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public BlogEngineDb()
            :base("name=BlogEngineDB")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
