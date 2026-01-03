using MortgageCalculator.Business;
using MortgageCalculator.Web.Models;
using MortgageCalculator.Web.Repos;
using MortgageCalculator.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MortgageCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new MortgageCalculatorViewModel());
        }


        [HttpPost]
        public ActionResult Index(MortgageCalculatorViewModel model)
        {
            if (model != null &&
               model.BorrowedAmount > 0 &&
               model.InterestRate > 0 &&
               model.LoanDurationYears > 0)
            {
                var service = new MortgageCalculatorService();

                var result = service.Calculate(
                    (decimal)model.BorrowedAmount,
                    model.InterestRate,
                    model.LoanDurationYears
                );

                model.TotalRepayment = result.TotalRepayment;
                model.TotalInterestPaid = result.TotalInterest;
            }

            return View(model);
        }

        public JsonResult GetMortgageTypes(string term)
        {
            IMortgageService service = new MortgageService();

            var types = service.GetAllMortgages()
                            .Select(m => m.Name)
                            .Distinct()
                            .Where(t => t.ToLower().Contains(term.ToLower()))
                            .ToList();

            return Json(types, JsonRequestBehavior.AllowGet);
        }

       


    }
}