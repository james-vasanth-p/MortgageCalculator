using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Business
{
    public class MortgageCalculatorService
    {
        public MortgageResult Calculate(decimal loanAmount, double interestRate, int years)
        {
            int months = years * 12;
            double monthlyRate = interestRate / 100 / 12;  // [P x r x (1+𝑟) ^𝑛] / [(1+𝑟) ^n-1]

            double monthlyPayment =
                (double)loanAmount *
                (monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                (Math.Pow(1 + monthlyRate, months) - 1);

            double totalRepayment = monthlyPayment * months;
            double totalInterest = totalRepayment - (double)loanAmount;

            return new MortgageResult
            {
                TotalRepayment = Math.Round(totalRepayment, 2),
                TotalInterest = Math.Round(totalInterest, 2)
            };
        }
    }
}