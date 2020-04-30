using hqh.project.EntityFrameCore.DbMigration.EntityFrameCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace hqh.project.EntityFrameCore.DbMigration
{
    [DependsOn(typeof(EntityFrameCoreModule))]
    [DependsOn(typeof(AbpEntityFrameworkCoreModule))]
    public class EntityFrameCoreDbMigrationModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HqhProjectDbContext>(options =>
            {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also webMigrationsDbContextFactory for EF Core tooling. */
                //options.UseMySQL();
                options.UseSqlServer();
            });
        }
    }
}
