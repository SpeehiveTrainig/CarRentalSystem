using CarRentalSystem.util;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index() // load FeedbackPage
        {
            return View();
        }


        public IActionResult AddData(string name1,string email,string msg)
        {

            ViewBag.Name = name1;

            Helper helper = new Helper();
            helper.FileWrite(name1, email, msg);

            return View();
        }






    }
}
