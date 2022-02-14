﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            var Projects = new List<KhasTarin>
            {
                new KhasTarin(1,"Taxi","درخواست آنلاین تاکسی برای پدرام","project-1.jpg","Pedram"),
                new KhasTarin(2,"Food","درخواست آنلاین غذا برای مهرسا","project-2.jpg","Mehrsa"),
                new KhasTarin(3,"Bus","درخواست آنلاین اتوبوس برای پردیس","project-3.jpg","Pardis"),
                new KhasTarin(4,"Tower","درخواست آنلاین برج برای غزل","project-4.jpg","Ghazal")
                
            };
            return View("Projects",Projects);
        }
    }
}
