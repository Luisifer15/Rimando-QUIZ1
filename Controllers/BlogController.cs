using Microsoft.AspNetCore.Mvc;
using Rimando___QUIZ1.Models;

namespace Rimando___QUIZ1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index(int year, int month, string slug)
        {
            var ModelViewBlog = new BlogsModel(); 

            if (year == 1 && month == 1) 
            {
                ModelViewBlog.BlogID = 1;
                ModelViewBlog.BlogContent = "Lorem ipsum 1 slug:" + slug;
                ModelViewBlog.BlogTitle = "Blog 1";
            } else if (year == 1 && month == 2) 
            {
                ModelViewBlog.BlogID = 2;
                ModelViewBlog.BlogContent = "Lorem ipsum 2 slug:" + slug;
                ModelViewBlog.BlogTitle = "Blog 2";
            } else if (year == 1 && month == 3) 
            {
                ModelViewBlog.BlogID = 3;
                ModelViewBlog.BlogContent = "Lorem ipsum 3 slug:" + slug;
                ModelViewBlog.BlogTitle = "Blog 3";
            } else if (year == 2 && month == 1) 
            {
                ModelViewBlog.BlogID = 4;
                ModelViewBlog.BlogContent = "Lorem ipsum 4 slug:" + slug;
                ModelViewBlog.BlogTitle = "Blog 4";
            } else if (year == 2 && month == 2) 
            {
                ModelViewBlog.BlogID = 5;
                ModelViewBlog.BlogContent = "Lorem ipsum 5 slug:" + slug;
                ModelViewBlog.BlogTitle = "Blog 5";
            } else if (year == 2 && month == 3  ) 
            {
                ModelViewBlog.BlogID = 6;
                ModelViewBlog.BlogContent = "Lorem ipsum 7 slug:" + slug;
                ModelViewBlog.BlogTitle = "Blog 8";
            } else {
                return Content("Invalid Blogpage");
            }
            

            return View(ModelViewBlog);
        }
    }
}
