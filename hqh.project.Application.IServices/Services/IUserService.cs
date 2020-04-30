using hqh.project.Common;
using hqh.project.Dtos;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace hqh.project.Application.Contract.Services
{
    public interface IUserService: IApplicationService
    {
        /// <summary>
        ///新增或编辑用户
        /// </summary>
        /// <returns></returns>
        Task<Result> AddEditUser(AddEditUserDto input);
    }
}
