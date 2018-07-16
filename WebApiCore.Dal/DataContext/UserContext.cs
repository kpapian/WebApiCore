using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Dal.DataModel;

namespace WebApiCore.Dal.DataContext
{
    /// <summary>
    /// Represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database
    /// </summary>
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initialize a new instance of the UserContext type.
        /// </summary>
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets User entities stored in the database
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets Role entities stored in the database
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets UserData entities stored in the database
        /// </summary>
        public DbSet<UserData> UserData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=EFCore.Users;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role userRole = new Role { Type = "user" };
            Role adminRole = new Role { Type = "admin" };

            List<Role> userRoleList = new List<Role>();

            userRoleList.Add(userRole);
            userRoleList.Add(adminRole);


            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Type = "user" },
                new Role { Id = 2, Type = "admin" });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Anna", RoleId = 1 },
                new User { Id = 2, Name = "Petr", RoleId = 2 },
                new User { Id = 3, Name = "Ira", RoleId = 1 },
                new User { Id = 4, Name = "Oleg", RoleId = 1 },
                new User { Id = 5, Name = "Karina", RoleId = 1 });

            modelBuilder.Entity<UserData>().HasData(
                new UserData { Id = 1, UserText = "My name is Anna. My role is user.", UserId = 1 },
                new UserData { Id = 2, UserText = "My name is Petr. My role is admin.", UserId = 2 },
                new UserData { Id = 3, UserText = "My name is Ira. My role is user.", UserId = 3 },
                new UserData { Id = 4, UserText = "My name is Oleg. My role is user.", UserId = 4 },
                new UserData { Id = 5, UserText = "My name is Karina. My role is user.", UserId = 5 });
        }
    }
}
