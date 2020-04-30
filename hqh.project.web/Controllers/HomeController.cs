using hqh.project.Application.IServices.Test;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace hqh.project.web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController: BaseController
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return Redirect("~/swagger");
        }

    }
}
