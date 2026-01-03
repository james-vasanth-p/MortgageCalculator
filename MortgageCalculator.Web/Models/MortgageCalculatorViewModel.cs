using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Web.Models
{
    public class MortgageCalculatorViewModel
    {
        public double BorrowedAmount { get; set; }
        public double InterestRate { get; set; }
        public int LoanDurationYears { get; set; }
        public double TotalRepayment { get; set; }
        public double TotalInterestPaid { get; set; }
        public string SelectedMortgageType { get; set; }

    }
}
