using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coreforzhihu.DAL
{
    public class coreforzhihuContext: DbContext
    {
        public coreforzhihuContext(DbContextOptions<coreforzhihuContext>options ) : base(options) { }
       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       //=> optionsBuilder.UseSqlServer(_connectionString);
    }
}

