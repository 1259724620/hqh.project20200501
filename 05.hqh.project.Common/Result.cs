using System;
using System.Collections.Generic;
using System.Text;

namespace hqh.project.Common
{
     /// <summary>
    /// 输出返回结果基类
    /// author:chenhm
    /// time:2018-10-10
    /// </summary>
    public class Result : IResult
    {
        /// <summary>
        /// 操作成功
        /// </summary>
        public const string SuccessCode = "Success";


        private string _message;

        /// <summary>
        /// 返回结果
        /// </summary>
        public Result()
        {

        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="code">状态码</param>
        /// <param name="message">提示信息</param>
        public Result(ResultCode code, string message = null)
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// 结果状态码
        /// <remark>
        /// 请求成功 1
        /// 请求失败 -1
        /// 身份验证失败 -2
        /// 数据为空 -3
        /// 提交数据检测未通过 -4
        /// 服务数据异常 -5
        /// 未授权访问系统 -6
        /// 提交数据验证不通过 -7
        /// IP验证不通过 -8
        /// 请求密码不正确 -9
        /// 传入参数有误或者为空 -10
        /// 不允许操作 -11
        /// </remark>
        /// </summary>
        public ResultCode Code { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <example>操作成功</example>
        public string Message
        {
            get { return _message ?? Code.DisplayName(); }
            set { _message = value; }
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success => Code == ResultCode.OK;

        public DateTime Time { get; set; } = DateTime.Now;

        #region 静态函数

        /// <summary>
        /// 返回指定 Code
        /// </summary>
        public static Result FromCode(ResultCode code, string message = null)
        {
            return new Result(code, message);
        }

        /// <summary>
        /// 返回指定 Code
        /// </summary>
        public static Result<T> FromCode<T>(ResultCode code, string message = null)
        {
            return new Result<T>(code, message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Result<T> FromCode<T>(ResultCode code, T data, string message = null)
        {
            return new Result<T>(code, message, data);
        }

        /// <summary>
        /// 返回异常信息
        /// </summary>
        public static Result FromError(string message, ResultCode code = ResultCode.Fail)
        {
            return new Result(code, message);
        }

        /// <summary>
        /// 返回异常信息
        /// </summary>
        public static Result<T> FromError<T>(string message, ResultCode code = ResultCode.Fail)
        {
            return new Result<T>(code, message);
        }

        /// <summary>
        /// 返回数据
        /// </summary>
        public static Result<T> FromData<T>(T data)
        {
            return new Result<T>(data);
        }

        /// <summary>
        /// 返回数据
        /// </summary>
        public static Result<T> FromData<T>(T data, string message)
        {
            return new Result<T>(ResultCode.OK, message, data);
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        public static Result Ok(string message = null)
        {
            return FromCode(ResultCode.OK, message);
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        public static Result<T> Ok<T>(T data)
        {
            return FromData(data);
        }

        #endregion
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    public class Result<TData> : Result, IResult<TData>
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public Result()
        {

        }

        /// <summary>
        /// 返回结果
        /// </summary>
        public Result(TData data)
            : base(ResultCode.OK)
        {
            Data = data;
        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="code">状态码</param>
        /// <param name="message">提示信息</param>
        public Result(ResultCode code, string message = null)
            : base(code, message)
        {

        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public Result(ResultCode code, string message = null, TData data = default(TData))
          : base(code, message)
        {
            Data = data;
        }

        /// <summary>
        /// 返回结果数据
        /// </summary>
        public TData Data { get; set; }
    }
}
