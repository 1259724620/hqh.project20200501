using hqh.project.Common;
using Volo.Abp.Modularity;

namespace hqh.project.Application.Contract
{
    /// <summary>
    /// 
    /// </summary>
    [DependsOn(typeof(CommonModule))]
    public class ApplicationContractModule:AbpModule
    {

    }
}
