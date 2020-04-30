using hqh.project.Application.IServices.Test;
using Volo.Abp.Application.Services;

namespace hqh.project.Application.Services.Test
{
    public class TestService : ApplicationService, ITestService
    {
        public string Test123()
        {
            return "Test*******************123";
        }
    }
}
