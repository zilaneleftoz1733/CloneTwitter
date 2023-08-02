using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ZILAN_ELEFTOZ;database=CloneProject; integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<RePost> RePosts { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }

    }
}
