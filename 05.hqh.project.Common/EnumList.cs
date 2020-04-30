using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace hqh.project.Common
{
    /// <summary>
    /// 枚举公用返回状态信息
    /// atuhor:chenhm
    /// time:2018-10-10
    /// </summary>
    [Description("枚举公用返回状态信息")]
    public enum ResultCode
    {
        /// <summary>请求成功（所有接口请求成功时默认值）</summary>
        [Display(Name = "请求成功")]
        OK = 1,

        /// <summary>请求失败（逻辑处理过程中需返回信息时使用）</summary>
        [Display(Name = "请求失败")]
        Fail = -1,

        /// <summary>身份验证失败（token失效或未登录）</summary>
        [Display(Name = "身份验证失败")]
        ValidateFail = -2,

        /// <summary>数据为空（查询数据库找不到数据时使用）</summary>
        [Display(Name = "数据为空")]
        NoRecord = -3,

        /// <summary>提交数据检测未通过（验证输入参数时使用）</summary>
        [Display(Name = "提交数据检测未通过")]
        RequestValidateFail = -4,

        /// <summary>服务数据异常（异常捕捉时使用）</summary>
        [Display(Name = "服务数据异常")]
        HandleError = -5,

        /// <summary>未授权访问系统（abp自身验证不通过时使用）</summary>
        [Display(Name = "未授权访问系统")]
        Deny = -6,

        /// <summary>abp系统自身提交数据验证不通过（仅在系统自动判断提交数据不合法时使用）</summary>
        [Display(Name = "提交数据验证不通过")]
        AbpRequestValidateFail = -7,


        /// <summary>IP验证有误（逻辑处理过程中需返回信息时使用）</summary>
        [Display(Name = "IP验证不通过")]
        IPFail = -8,

        /// <summary>请求密码不正确（逻辑处理过程中需返回信息时使用）</summary>
        [Display(Name = "请求密码不正确")]
        PasswordFail = -9,

        /// <summary>传入参数有误或者为空（逻辑处理过程中需返回信息时使用）</summary>
        [Display(Name = "传入参数有误或者为空")]
        ParameterFail = -10,

        /// <summary>不允许操作</summary>
        [Display(Name = "不允许操作")]
        NotAllow = -11
    }

    /// <summary>
    /// 定义 <see cref="System.ComponentModel.DataAnnotations.DisplayAttribute"/> 的属性
    /// </summary>
    public enum DisplayProperty
    {
        /// <summary>
        /// 名称
        /// </summary>
        Name,

        /// <summary>
        /// 短名称
        /// </summary>
        ShortName,

        /// <summary>
        /// 分组名称
        /// </summary>
        GroupName,

        /// <summary>
        /// 说明
        /// </summary>
        Description,

        /// <summary>
        /// 排序
        /// </summary>
        Order,

        /// <summary>
        /// 水印信息
        /// </summary>
        Prompt,
    }
}
