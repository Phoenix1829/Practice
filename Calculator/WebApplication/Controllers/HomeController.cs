using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "+", Text ="+" },
                new SelectListItem() { Value = "-", Text ="-" },
                new SelectListItem() { Value = "*", Text ="*" },
                new SelectListItem() { Value = "/", Text ="/" },
                new SelectListItem() { Value = "^", Text ="^" },
                new SelectListItem() { Value = "%", Text ="%" }
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

        [HttpPost]
        public ActionResult Index(
        double x,
        double y,
        string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    var sum = new Operations.Sum();
                    result = sum.Calculate(x, y);
                    break;

                case "-":
                    var diff = new Operations.Diff();
                    result = diff.Calculate(x, y);
                    break;

                case "*":
                    var mult = new Operations.Mult();
                    result = mult.Calculate(x, y);
                    break;
                case "/":
                    var div = new Operations.Div();
                    result = div.Calculate(x, y);
                    break;

                case "^":
                    var pow = new Operations.Pow();
                    result = pow.Calculate(x, y);
                    break;

                case "%":
                    var ostat = new Operations.Ostat();
                    result = ostat.Calculate(x, y);
                    ViewBag.Result = result;
                    break;
            }

            ViewBag.Result = result;

            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "+", Text ="+" },
                new SelectListItem() { Value = "-", Text ="-" },
                new SelectListItem() { Value = "*", Text ="*" },
                new SelectListItem() { Value = "/", Text ="/" },
                new SelectListItem() { Value = "^", Text ="^" },
                new SelectListItem() { Value = "%", Text ="%" }
            };
            return View();
        }
    }
}