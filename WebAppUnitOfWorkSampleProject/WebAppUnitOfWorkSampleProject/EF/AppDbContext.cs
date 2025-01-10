/*
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
Install-package Microsoft.EntityFrameworkCore.Proxies

Add-Migration InitialCreate -Context "AppDbContext"
Update-Database -Context "AppDbContext"
Script-Migration -Context "AppDbContext"
*/

using Microsoft.EntityFrameworkCore;
using WebAppUnitOfWorkSampleProject.EF.Model;

namespace WebAppUnitOfWorkSampleProject.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
