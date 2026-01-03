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
                    Name = "Standard Home Loan",
                    MortgageType = MortgageType.Fixed,
                    InterestRepayment = InterestRepayment.PrincipalAndInterest,
                    EffectiveStartDate = DateTime.Today.AddYears(-1),
                    EffectiveEndDate = DateTime.Today.AddYears(25),
                    CancellationFee = 5000,
                    EstablishmentFee = 10000
                },
                new Mortgage
                {
                    MortgageId = 2,
                    Name = "Car Loan",
                    MortgageType = MortgageType.Variable,
                    InterestRepayment = InterestRepayment.InterestOnly,
                    EffectiveStartDate = DateTime.Today.AddYears(-2),
                    EffectiveEndDate = DateTime.Today.AddYears(5),
                    CancellationFee = 2000,
                    EstablishmentFee = 3000
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
