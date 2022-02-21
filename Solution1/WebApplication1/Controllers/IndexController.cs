using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;
using WebApplication1.ProjectsData;

namespace WebApplication1.Controllers
{
    [Route("")]
    public class IndexController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس")
        };
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("ProjectDetails")]
        public IActionResult ProjectDetails(long id)
        {
            ProjectsStore Store = new ProjectsStore();
            var project = Store.GetKhasTarinBy(id);
            return View(project);
        }
        [HttpGet("MyContactPage")]
        //[Route("MyContactPage")]
        public IActionResult Contact()
        {
            var model = new ContactModel
            {
                Services = new SelectList(_services,"Id","Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.False = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید";
                return View(model);
            }
            ModelState.Clear();
            model = new ContactModel
            {
                Services = new SelectList(_services,"Id","Name")
            };
            ViewBag.Success = "با موفقیت انجام شد با تشکر";
            return View(model);
        }
    }
}
