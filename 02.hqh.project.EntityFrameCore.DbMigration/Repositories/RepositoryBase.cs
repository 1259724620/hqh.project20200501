using hqh.project.EntityFrameCore.DbMigration.EntityFrameCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace hqh.project.EntityFrameCore.DbMigration.Repositories
{
    public abstract class RepositoryBase<Entity,PrimaryKey>:EfCoreRepository<HqhProjectDbContext, Entity, PrimaryKey> 
        where Entity: class, IEntity<PrimaryKey>
    {
        protected RepositoryBase(IDbContextProvider<HqhProjectDbContext> dbContextProvider)
          : base(dbContextProvider)
        {

        }
    }

    public abstract class HqhProjectRepositoryBase<TEntity>: RepositoryBase<TEntity,int>
         where TEntity : class, IEntity<int>
    {
        protected HqhProjectRepositoryBase(IDbContextProvider<HqhProjectDbContext> dbContextProvider)
           : base(dbContextProvider)
        {

        }
    }
}
