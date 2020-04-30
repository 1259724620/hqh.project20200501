using hqh.project.Common;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace hqh.project.web.Swagger
{
    /// <summary>
    /// 枚举参数示例
    /// </summary>
    public class EnumSchemaFilter : ISchemaFilter
    {
        /// <summary>
        /// 设置枚举显示
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var enumType = context.Type.GetNonNullableType();
            if (enumType.IsEnum)
            {
                var extensions = new Dictionary<string, IOpenApiExtension>();
                foreach (Enum value in Enum.GetValues(enumType))
                {
                    var display = value.DisplayName();
                    extensions.Add(Convert.ToInt32(value).ToString("G"), new OpenApiString(string.IsNullOrWhiteSpace(display) ? "" : ":" + display));
                }
                schema.Extensions = extensions;
                if (string.IsNullOrWhiteSpace(schema.Description))
                {
                    schema.Description = enumType.DisplayDescription();
                }
            }
        }
    }
}

    
