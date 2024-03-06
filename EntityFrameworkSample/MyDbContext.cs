using EntityFrameworkSample.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSample
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbContext")
        {
            
        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
