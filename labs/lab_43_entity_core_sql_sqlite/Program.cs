using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace lab_43_entity_core_sql_sqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            // user database
            List<User> users = new List<User>();
            List<Category> categories = new List<Category>();

            using (var db = new UserDataBaseContext())
            {
                users = db.Users.ToList();
                categories = db.Categories.ToList();
                users.ForEach(x => Console.WriteLine(x.UserName));
                categories.ForEach(x => Console.WriteLine(x.CategoryName));


            }
        }
    }
    class UserDataBaseContext : DbContext
    {
        //db set map tables to classes
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    
        //connection string
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // using the sqlite server we built locally 
            // builder.UseSqlite(@"C:\2020-01-CSharpLabs\SQLite\test.db");
        }
    }

    public class User
    {

        public int UserID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public bool? isValid { get; set; }

        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public Category()
        {
            Users = new HashSet<User>();
        }

        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

