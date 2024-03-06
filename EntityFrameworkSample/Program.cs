using EntityFrameworkSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDbContext db = new MyDbContext();
            db.Students.Add(new StudentModel { Name = "Marc Dominic Magat", Description = "My Description" });
            db.SaveChanges();
            Console.WriteLine("Saved");
            Console.ReadLine();
        }
    }
}
