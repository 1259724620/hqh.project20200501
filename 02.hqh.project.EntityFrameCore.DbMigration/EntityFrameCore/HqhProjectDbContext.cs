using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace hqh.project.EntityFrameCore.DbMigration.EntityFrameCore
{
    /// <summary>
    /// 上下文类
    /// </summary>
    [ConnectionStringName("Default")]
    public class HqhProjectDbContext: AbpDbContext<HqhProjectDbContext>
    {
        public HqhProjectDbContext(DbContextOptions<HqhProjectDbContext> options)
           : base(options)
        {

        }

        public DbSet<User> User{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure your own tables/entities inside the Configureweb method */
            builder.Builder();
        }
    }
}
