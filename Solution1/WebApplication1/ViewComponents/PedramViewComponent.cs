using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class PedramViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>
            {
                new Article(1,"آموزش پست گذاشتن","بهترین آموزش پست گذاشتن در اینستاگرام.","blog-post-thumb-1.jpg"),
                new Article(2,"برنامه نویسی","از چه زبان برنامه نویسی استفاده کنیم مفید تر است؟","blog-post-thumb-2.jpg"),
                new Article(3,"آموزش آبیاری گیاهان دریایی"," آبیاری گیاهان دریاایی .بهترین آموزش روشهای .","blog-post-thumb-3.jpg"),
                new Article(4,"آموزش رانندگی با کیبورد","بهترین آموزش رانندگی با کیبورد.","blog-post-thumb-4.jpg"),
            };
            return View("Second", Articles);
        }
    }
}
