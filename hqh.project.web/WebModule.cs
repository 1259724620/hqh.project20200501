using hqh.project.Application.Contract;
using hqh.project.Application.Services;
using hqh.project.Common;
using hqh.project.EntityFrameCore;
using hqh.project.EntityFrameCore.DbMigration;
using hqh.project.EntityFrameCore.DbMigration.EntityFrameCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System;
using System.IO;
using hqh.project.web.Swagger;

namespace hqh.project.web
{
    /// <summary>
    /// 
    /// </summary>
    [DependsOn(typeof(AbpAspNetCoreMvcModule))]
    [DependsOn(typeof(AbpAutofacModule))] // 在模块上添加依赖AbpAutofacModule
    [DependsOn(typeof(EntityFrameCoreModule))]
    [DependsOn(typeof(EntityFrameCoreDbMigrationModule))]
    [DependsOn(typeof(ApplicationContractModule))]
    [DependsOn(typeof(ApplicationServiceModule))]
    [DependsOn(typeof(CommonModule))]
    [DependsOn(typeof(AbpAspNetCoreMvcModule))]
    public class WebModule : AbpModule
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var services = context.Services;
            services.AddMvc(options => { options.EnableEndpointRouting = false; });
            services.AddAssemblyOf<WebModule>();
            //数据库表Configure DbContext
            services.AddAbpDbContext<HqhProjectDbContext>();
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("hqhproject_v1", new OpenApiInfo { Title = "hqhproject后台接口", Version = "v1" });
                //开启显示注释
                var dic = Path.GetDirectoryName(GetType().Assembly.Location);
                foreach (var file in Directory.EnumerateFiles(dic, "*.xml"))
                {
                    c.IncludeXmlComments(file);
                }
                //隐藏Api
                c.DocumentFilter<SwaggerIgnoreFilter>();
				//设置显示枚举
                c.SchemaFilter<EnumSchemaFilter>();
            });

            //base.ConfigureServices(context);
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/hqhproject_v1/swagger.json", "hqhproject接口文档");
            });

            app.UseMvcWithDefaultRoute();
            app.UseMvc();
        }
    }
}
