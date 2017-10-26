using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreforzhihu.DAL.Entities;

namespace coreforzhihu.DAL
{
    public class coreforzhihuContext: DbContext
    {
        public coreforzhihuContext(DbContextOptions<coreforzhihuContext>options ) : base(options) { }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer(_connectionString);
        public DbSet<userInfo> users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

