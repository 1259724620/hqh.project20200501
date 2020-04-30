using hqh.project.Application.Contract.Services;
using hqh.project.Common;
using hqh.project.Dtos;
using hqh.project.EntityFrameCore;
using hqh.project.EntityFrameCore.IRepositories;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace hqh.project.Application.Services.Services
{
    public class UserService:ApplicationService, IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        ///新增或编辑用户
        /// </summary>
        /// <returns></returns>
        public async Task<Result> AddEditUser(AddEditUserDto input)
        {
            var exist = _userRepository.Any(f => f.Account == input.Account&&f.Id!=input.Id);
            if (exist)
                return Result.FromError("账号已存在");

            if (input.Id <= 0)
            {
                var entity = input.MapTo<User>();
                await _userRepository.InsertAsync(entity);
            }
            else
            {
                var entity = _userRepository.FirstOrDefault(f=>f.Id==input.Id);
                var newEntity = MapperHelper.ResultData(input, entity);
                await _userRepository.UpdateAsync(newEntity);
            }
            return Result.Ok();
        }

    }
}
