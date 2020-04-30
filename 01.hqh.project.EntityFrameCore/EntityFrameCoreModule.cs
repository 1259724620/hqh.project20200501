using hqh.project.Common;
using Volo.Abp.Modularity;

namespace hqh.project.EntityFrameCore
{
    [DependsOn(typeof(CommonModule))]
    public class EntityFrameCoreModule : AbpModule
    {
    }
}
