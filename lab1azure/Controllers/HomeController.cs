using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab1azure.Models;

namespace lab1azure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator model, String calc)
        {
            switch (calc)
            {
                case "Add":
                    model.result = model.firstNumber + model.secondNumber;
                    break;
                case "Sub":
                    model.result = model.firstNumber - model.secondNumber;
                    break;
                case "Mult":
                    model.result = model.firstNumber * model.secondNumber;
                    break;
                case "Div":
                    model.result = model.firstNumber / model.secondNumber;
                    break;
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}