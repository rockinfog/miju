using Abp.Zero.EntityFrameworkCore;
using AowenPlatform.Authorization.Roles;
using AowenPlatform.Authorization.Users;
using AowenPlatform.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace AowenPlatform.EntityFrameworkCore
{
    public class AowenPlatformDbContext : AbpZeroDbContext<Tenant, Role, User, AowenPlatformDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public AowenPlatformDbContext(DbContextOptions<AowenPlatformDbContext> options)
            : base(options)
        {

        }
    }
}
