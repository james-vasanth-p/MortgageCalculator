using MortgageCalculator.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator.Data
{
    public class MortgageDataContext: IDisposable
    {
        private readonly List<Mortgage> _mortgages;

        public MortgageDataContext()
        {
            _mortgages = new List<Mortgage>
    {
        new Mortgage
        {
            MortgageId = 1,
            Name = "Home Loan",
            MortgageType = MortgageType.Fixed,
            InterestRepayment = InterestRepayment.PrincipalAndInterest,
            InterestRate = 7.5m,
            EffectiveStartDate = DateTime.Today.AddYears(-1),
            EffectiveEndDate = DateTime.Today.AddYears(25),
            CancellationFee = 5000,
            EstablishmentFee = 10000,
            IsActive = true
        },
        new Mortgage
        {
            MortgageId = 2,
            Name = "Car Loan",
            MortgageType = MortgageType.Variable,
            InterestRepayment = InterestRepayment.InterestOnly,
            InterestRate = 8.2m,
            EffectiveStartDate = DateTime.Today.AddYears(-2),
            EffectiveEndDate = DateTime.Today.AddYears(5),
            CancellationFee = 2000,
            EstablishmentFee = 3000,
            IsActive = true
        },
        new Mortgage
        {
            MortgageId = 3,
            Name = "Gold Loan",
            MortgageType = MortgageType.Fixed,
            InterestRepayment = InterestRepayment.PrincipalAndInterest,
            InterestRate = 11.0m,
            IsActive = false,
            EffectiveStartDate = DateTime.Today.AddYears(-1),
            EffectiveEndDate = DateTime.Today.AddYears(3),
            CancellationFee = 1500,
            EstablishmentFee = 2000
        }
    };
        }

        public IQueryable<Mortgage> Mortgages
        {
            get { return _mortgages.AsQueryable(); }
        }
        public void Dispose()
        {
            
        }
    }
}
