using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Сложение", Text ="Сложение" },
                new SelectListItem() { Value = "Вычитание", Text ="Вычитание" },
                new SelectListItem() { Value = "Умножение", Text ="Умножение" },
                new SelectListItem() { Value = "Деление", Text ="Деление" },
                new SelectListItem() { Value = "Степень", Text ="Степень" },
                new SelectListItem() { Value = "Остаток от деления", Text ="Остаток от деления" }
            };
            return View();
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
        public ActionResult Index(
        double firstArgument,
        double secondArgument,
        string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "Сложение":
                    var addition = new Operations.Sum();
                    result = addition.Calculate(firstArgument, secondArgument);
                    break;

                case "Вычитание":
                    var subtraction = new Operations.Diff();
                    result = subtraction.Calculate(firstArgument, secondArgument);
                    break;

                case "Умножение":
                    var multiplication = new Operations.Mult();
                    result = multiplication.Calculate(firstArgument, secondArgument);
                    break;
                case "Деление":
                    var division = new Operations.Div();
                    result = division.Calculate(firstArgument, secondArgument);
                    break;

                case "Степень":
                    var step = new Operations.Step();
                    result = step.Calculate(firstArgument, secondArgument);
                    break;

                case "Остаток от деления":
                    var ostat = new Operations.Ostat();
                    result = ostat.Calculate(firstArgument, secondArgument);
                    ViewBag.Result = result;
                    break;
            }


            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Сложение", Text ="Сложение" },
                new SelectListItem() { Value = "Вычитание", Text ="Вычитание" },
                new SelectListItem() { Value = "Умножение", Text ="Умножение" },
                new SelectListItem() { Value = "Деление", Text ="Деление" },
                new SelectListItem() { Value = "Степень", Text ="Степень" },
                new SelectListItem() { Value = "Остаток от деления", Text ="Остаток от деления" }
            };
            return View();
        }
    }
}
