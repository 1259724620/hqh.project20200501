using hqh.project.EntityFrameCore.DbMigration.EntityFrameCore;
using hqh.project.EntityFrameCore.IRepositories;
using Volo.Abp.EntityFrameworkCore;

namespace hqh.project.EntityFrameCore.DbMigration.Repositories
{
    public class UserRepository : HqhProjectRepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbContextProvider<HqhProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
