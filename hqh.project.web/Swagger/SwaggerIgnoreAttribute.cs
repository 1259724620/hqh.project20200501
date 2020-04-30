using System;

namespace hqh.project.web.Swagger
{
    /// <summary>
    /// 隐藏Swagger Api特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class SwaggerIgnoreAttribute : Attribute
    {

    }
}
