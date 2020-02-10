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
            List<Company> companies = new List<Company>();

            using (var db = new UserDataBaseContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Category admin = new Category() { CategoryID = 1, CategoryName = "BOSS" };

                Company amazon = new Company() { CompanyName = "Amazon", CompanyID = 1 };

                User tim = new User() { UserName = "Tim", CategoryID = 1, DateOfBirth = DateTime.Now, isValid = true, UserID = 1 , CompanyID = 1 };

                users = db.Users.ToList();
                categories = db.Categories.ToList();

                Console.WriteLine($"{tim.UserName} is an employee {tim.Company.CompanyName} and is the {tim.Category.CategoryName}");
                

            }
        }
    }
    class UserDataBaseContext : DbContext
    {
        //db set map tables to classes
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
    
        //connection string
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // using the sqlite server we built locally 
            //builder.UseSqlite("Data Source = test.db");
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

        public int? CompanyID { get; set; }

        public virtual Company Company { get; set; }
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
    public class Company
    {

        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

    }
}

