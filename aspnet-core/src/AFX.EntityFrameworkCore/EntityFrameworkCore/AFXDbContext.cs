using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AFX.Authorization.Roles;
using AFX.Authorization.Users;
using AFX.MultiTenancy;

namespace AFX.EntityFrameworkCore
{
    public class AFXDbContext : AbpZeroDbContext<Tenant, Role, User, AFXDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AFXDbContext(DbContextOptions<AFXDbContext> options)
            : base(options)
        {
        }
    }
}
