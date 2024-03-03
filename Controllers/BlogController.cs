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
                ModelViewBlog.BlogContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eu sollicitudin orci. Phasellus consequat, nunc ut tincidunt viverra, ipsum diam ultrices elit, vitae posuere purus velit at lacus. Donec pulvinar neque leo, nec lobortis elit dictum et. Cras eros augue, pretium at odio nec, luctus tincidunt massa. Proin blandit, leo eu vulputate consequat, lacus urna luctus nulla, ut condimentum dui sem at tellus. Fusce nec ante et velit molestie viverra quis bibendum sem. Suspendisse faucibus, risus ut sollicitudin hendrerit, nunc velit molestie risus, sit amet scelerisque purus lacus sit amet tortor. Integer ipsum leo, fringilla ac malesuada sit amet, sodales a sem. Phasellus dapibus nec neque id pulvinar." + slug;
                ModelViewBlog.BlogTitle = "Blog 1";
            } else if (year == 1 && month == 2) 
            {
                ModelViewBlog.BlogID = 2;
                ModelViewBlog.BlogContent = "Nullam feugiat at nisl eget sagittis. Cras sed sem a metus sagittis faucibus. Morbi luctus blandit mauris, a ullamcorper libero tincidunt at. Phasellus commodo felis lorem, sed maximus nisi hendrerit in. Cras elit lorem, facilisis nec scelerisque quis, facilisis id risus. Quisque tristique dignissim nulla, in bibendum mi elementum a. Sed vitae libero enim. Cras aliquam sagittis gravida. Quisque varius turpis id nunc lacinia porta. Aenean vehicula ex sit amet blandit lacinia. Donec lorem velit, porta non lacus posuere, venenatis luctus libero.  slug: " + slug;
                ModelViewBlog.BlogTitle = "Blog 2";
            } else if (year == 1 && month == 3) 
            {
                ModelViewBlog.BlogID = 3;
                ModelViewBlog.BlogContent = "Ut sit amet aliquam risus, id vestibulum leo. Nullam tincidunt diam ultricies tellus ornare finibus. Praesent efficitur fermentum orci sed sollicitudin. Ut condimentum ante vel ligula pulvinar ornare. Curabitur est augue, finibus eget luctus nec, condimentum quis eros. Donec eleifend velit cursus eros facilisis, quis dictum orci scelerisque. Mauris turpis ex, dignissim eget orci sed, imperdiet accumsan nulla. Quisque a tortor arcu. Aliquam quis ipsum vitae nisi ultrices volutpat. Curabitur et dui ac sapien suscipit viverra eget in ipsum. Aliquam at lacus malesuada, malesuada leo sit amet, rutrum massa.  slug: " + slug;
                ModelViewBlog.BlogTitle = "Blog 3";
            } else if (year == 2 && month == 1) 
            {
                ModelViewBlog.BlogID = 4;
                ModelViewBlog.BlogContent = "Maecenas commodo porttitor nunc, at sodales magna. Nulla vehicula dui id nunc vehicula facilisis. Aliquam erat volutpat. Mauris lacinia semper justo, nec fermentum est commodo quis. Duis et dictum purus, in volutpat turpis. Sed at semper magna. Nunc congue diam augue, a malesuada nisl fringilla vitae. Maecenas pretium malesuada sapien sit amet faucibus. Aenean et placerat est, nec dictum lectus. Fusce nec egestas ligula. Donec luctus magna erat, eu dapibus sem hendrerit quis. Quisque nec volutpat nisl. Proin nec accumsan lacus, eleifend malesuada nulla. Sed imperdiet diam in facilisis tincidunt.  slug: " + slug;
                ModelViewBlog.BlogTitle = "Blog 4";
            } else if (year == 2 && month == 2) 
            {
                ModelViewBlog.BlogID = 5;
                ModelViewBlog.BlogContent = "Fusce vel laoreet urna. Vestibulum scelerisque id nisi eget interdum. Proin efficitur leo sit amet varius vestibulum. Phasellus vehicula volutpat ligula. Suspendisse ultricies sollicitudin erat, at facilisis mauris consectetur vel. Pellentesque ut felis semper, congue elit in, varius ipsum. Nullam pretium nisi at dictum iaculis. Pellentesque dictum mi quam, sed faucibus felis dictum eget. Fusce mattis, eros vel dictum auctor, ex odio dignissim nisi, a vulputate nisl purus et est. Nullam luctus porta sapien in maximus. Cras sit amet pellentesque mi. Quisque ut nulla in erat sollicitudin tempus. Curabitur vestibulum nulla sit amet malesuada lacinia. Sed et nunc massa. Suspendisse potenti.  slug: " + slug;
                ModelViewBlog.BlogTitle = "Blog 5";
            } else if (year == 2 && month == 3  ) 
            {
                ModelViewBlog.BlogID = 6;
                ModelViewBlog.BlogContent = "Nullam feugiat laoreet hendrerit. Vivamus ac metus et ipsum convallis lacinia et in quam. Maecenas laoreet imperdiet nunc non fringilla. Mauris a bibendum sem, sed maximus diam. Suspendisse cursus sed ligula sollicitudin iaculis. Mauris tristique semper augue ut scelerisque. Phasellus nec ex quis enim consequat porttitor ac nec mi. Curabitur eget sem diam. Duis fermentum lacinia nunc, laoreet molestie sapien vestibulum et. Suspendisse non diam suscipit, tristique odio nec, consequat nibh. Cras suscipit consequat est, nec lacinia turpis pharetra in. Aenean euismod vestibulum eros, sit amet laoreet neque accumsan sed. Pellentesque tincidunt nisi quis condimentum aliquam. Quisque rutrum at est vitae laoreet. Sed sit amet dolor dapibus, laoreet purus sit amet, faucibus mauris. Morbi venenatis rhoncus dui, non ultrices mi varius a.  slug: " + slug;
                ModelViewBlog.BlogTitle = "Blog 6";
            } else {
                return Content("Invalid Blogpage");
            }
            

            return View(ModelViewBlog);
        }
    }
}
