using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public ContentResult Index()
        {
            /*
            return new ContentResult()
            {
                Content = "Hello from Index",
                ContentType = "text/plain"
            };
            */
            //return Content("Hello from Index", "text/plain");

            return Content("<h1>Welcome to the Index page</h1> <h2> New line </h2>", "text/html");


        }

        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person() { Id = Guid.NewGuid(), FirstName = "John" , LastName = "Smith", Age = 25};
            return Json(person);
        }

        [Route("about")]
        public string About()
        {
            return "Hello from home";
        }

        //Using regex to create right format
        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello from contact page";
        }

        //Work with files
        [Route("file-download")]
        public VirtualFileResult FileDownload()
        {
            //return new VirtualFileResult("/test.pdf", "application/pdf");
            return File("/test.pdf", "application/pdf");
        }

        [Route("file-download2")]

        public IActionResult FileDownload2()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(@"c:\Controllers\test.pdf");
            //return new FileContentResult(bytes, "application/pdf");
            return File(bytes, "application/pdf");
        }


    }
}
