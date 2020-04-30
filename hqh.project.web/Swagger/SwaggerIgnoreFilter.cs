using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using System.Reflection;

namespace hqh.project.web.Swagger
{
    /// <summary>
    /// Swagger Api 过滤器
    /// </summary>
    public class SwaggerIgnoreFilter : IDocumentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var ignoreApis = context.ApiDescriptions.Where(m =>
            m.RelativePath.StartsWith("Abp") || m.RelativePath.StartsWith("api/abp")
            || (m.TryGetMethodInfo(out MethodInfo methodInfo) && methodInfo.CustomAttributes.Any(info => info.AttributeType == typeof(SwaggerIgnoreAttribute))));
            if (ignoreApis != null)
            {
                foreach (var ignoreApi in ignoreApis)
                {
                    swaggerDoc.Paths.Remove("/" + ignoreApi.RelativePath);
                }
            }
        }
    }
}
