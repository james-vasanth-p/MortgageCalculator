using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Web.Models
{
    public class MortgageCalculatorViewModel
    {
        [Display(Name = "Amount (₹)")]
        public double BorrowedAmount { get; set; }
        [Display(Name = "Interest Rate")]
        public double InterestRate { get; set; }
        [Display(Name = "Tenure")]
        public int LoanDurationYears { get; set; }
        [Display(Name = "Total Repayment")]
        public double TotalRepayment { get; set; }
        public double TotalInterestPaid { get; set; }
        [Display(Name = "Mortgage Type")]
        public string SelectedMortgageType { get; set; }

    }
}
