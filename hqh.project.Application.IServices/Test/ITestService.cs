using Volo.Abp.Application.Services;

namespace hqh.project.Application.IServices.Test
{
    public interface ITestService : IApplicationService
    {
        string Test123();
    }
}
