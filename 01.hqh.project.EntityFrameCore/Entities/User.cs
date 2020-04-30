using Volo.Abp.Domain.Entities.Auditing;

namespace hqh.project.EntityFrameCore
{
    public class User: BaseEntity<int>
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }
    }
}
