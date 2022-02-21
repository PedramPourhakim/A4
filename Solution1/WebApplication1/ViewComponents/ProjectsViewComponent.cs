using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ProjectsData;

namespace WebApplication1.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            ProjectsStore Store = new ProjectsStore();
            var model=Store.GetProjects();
            return View("Projects",model);
        }
    }
}
