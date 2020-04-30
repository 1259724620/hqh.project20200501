using System.ComponentModel.DataAnnotations;

namespace hqh.project.Dtos
{
    /// <summary>
    /// 薪增编辑
    /// </summary>
    public class AddEditUserDto: IntEntityDto
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required]
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string UserName { get; set; }
    }
}
