using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Zoo.Authorization.Roles;
using Zoo.Authorization.Users;
using Zoo.MultiTenancy;
using Zoo.Domain;

namespace Zoo.EntityFrameworkCore
{
    public class ZooDbContext : AbpZeroDbContext<Tenant, Role, User, ZooDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        public ZooDbContext(DbContextOptions<ZooDbContext> options)
            : base(options)
        {
        }
    }
}
