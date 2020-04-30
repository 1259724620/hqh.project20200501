using hqh.project.Application.Contract;
using hqh.project.Common;
using hqh.project.EntityFrameCore;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace hqh.project.Application.Services
{
    [DependsOn(typeof(ApplicationContractModule))]
    [DependsOn(typeof(EntityFrameCoreModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    [DependsOn(typeof(CommonModule))]
    public class ApplicationServiceModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<HqhProjectAutoMapperProfile>(validate: true);
            });
        }
    }
}
