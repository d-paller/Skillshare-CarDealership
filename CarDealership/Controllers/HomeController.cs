using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership.Model;
using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Focus";
            car.MPG = 31;
            car.Type = Model.Enum.CarTypes.Sedan;
            car.Year = 2014;

            viewModel.Car = car;

            return View(viewModel);
        }
    }
}