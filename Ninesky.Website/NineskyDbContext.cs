using Ninesky.User.Models;
using System.Data.Entity;

namespace Ninesky.Website
{
    /// <summary>
    /// 网站数据上下文
    /// <remarks>
    /// 创建：2014.12.13
    /// </remarks>
    /// </summary>
    public class NineskyDbContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }

        public NineskyDbContext()
            : base("name=NineskyConnection")
        {
            Database.SetInitializer<NineskyDbContext>(new CreateDatabaseIfNotExists<NineskyDbContext>());
        }
    }
}