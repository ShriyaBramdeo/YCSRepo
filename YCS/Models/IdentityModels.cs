using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YCS.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public string UserRoles { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public string Gender { get; set; }
        
        public long ContactNumber { get; set; }

        public string Address { get; set; }
        
        public string UserRoles { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       // public DbSet<Employee> Employees { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Salary> Salaries  { get; set; }
        public DbSet<Client> Clients  { get; set; }
       // public DbSet<Tracking> Trackings  { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       // public System.Data.Entity.DbSet<YCS.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}