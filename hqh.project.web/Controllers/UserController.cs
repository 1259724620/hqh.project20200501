using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hqh.project.Application.Contract.Services;
using hqh.project.Common;
using hqh.project.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace hqh.project.web.Controllers
{
    /// <summary>
    /// 用户控制器
    /// </summary>
    public class UserController : BaseController
    {
        /// <summary>
        ///新增或编辑用户
        /// </summary>
        /// <returns></returns>
        [HttpPost("AddEditUser")]
        public async Task<Result> AddEditUser([FromBody]AddEditUserDto input, [FromServices]IUserService service)
        {
            return await service.AddEditUser(input);
        }
    }
}