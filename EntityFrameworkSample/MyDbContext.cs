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
        //Constructor so that I can pass the connection string to the base class
        //Connection string is from the app.config
        public MyDbContext() : base("MyDbContext")
        {
            
        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
