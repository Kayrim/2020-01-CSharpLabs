using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;


namespace lab_45_entity_core_sql_sqlite
{
    class Program
    {
        static List<User> users = new List<User>();
        static List<Category> categories = new List<Category>();

        static void Main(string[] args)
        {
            // use database
            using (var db = new UserDatabaseContext())
            {
                users = db.Users.ToList();
                categories = db.Categories.ToList();
            }
            users.ForEach(u => Console.WriteLine($"{u.UserId,-10}"));

        }
    }

    // talk to database
    public class UserDatabaseContext : DbContext
    {
        // db set to map tables to c# classes
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        // connection string
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // if sqlite

            //builder.UseSqlite(@"C:\2020-01-c-sharp-labs\SQLite\test.db");
        }



    }

    public class User
    {
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public bool? isValid { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public Category()
        {
            Users = new HashSet<User>();
        }

        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }


}
