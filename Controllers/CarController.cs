using CarRentalSystem.DTOS;
using CarRentalSystem.Models;
using CarRentalSystem.util;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult page1()
        {
            return View();
        }


        public IActionResult page2()
        {
            return View();
        }


        [HttpGet]
        public IActionResult IndexPage()// load a page with a form to insert data for car
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCarDetails(Car newCar)
        {
            // write code for inserting newcar details to DATABASE /FILE

            Helper helper = new Helper();


            //CarDTO carDTO = new CarDTO();

            //carDTO.Name=newCar.Name;
            //carDTO.CompanyName=newCar.CompanyName;
            //carDTO.HrUsed=newCar.HrUsed;
           
            helper.SaveCarDetailsToFile(newCar);


          return View();
        }





    }
}
