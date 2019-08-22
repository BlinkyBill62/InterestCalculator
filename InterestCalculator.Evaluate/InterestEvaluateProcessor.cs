using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestCalculator.Data;

namespace InterestCalculator.Evaluate
{
    public class InterestEvaluateProcessor : IInterestEvaluateProcessor
    {
      

        public decimal Interest(float balance)
        {
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Account Balance cannot be less than zero");
            }
            decimal interest = GetInterest(balance); 
            return interest;
        }

      

        public decimal GetInterest(float balance)
        {
            decimal interest = 0;
            List<InterestRate> interestrates = _allInterest;
            foreach (var interestrate in interestrates)
            {
                if (interestrate.Upper != 0)
                {
                    if (balance >= interestrate.Lower & balance <= interestrate.Upper)
                    {
                        interest = Convert.ToDecimal(balance * interestrate.Rate);
                    }
                }
                else
                {
                    if (balance >= interestrate.Lower)
                    {
                        interest = Convert.ToDecimal(balance * interestrate.Rate);

                    }
                }
            }
            interest = Decimal.Round(interest,2);
            return interest;
        }

      
        public static List<InterestRate> _allInterest = new List<InterestRate>
        {
            new InterestRate { Lower = (float)0.00, Upper = (float)999.99, Rate = (float)0.01 },
            new InterestRate { Lower = (float)1000, Upper = (float)4999.99, Rate = (float)0.015 },
            new InterestRate { Lower = (float)5000, Upper = (float)9999.99, Rate = (float)0.02 },
            new InterestRate { Lower = (float)10000, Upper = (float)49999.99, Rate = (float)0.025 },
            new InterestRate { Lower = (float)50000, Upper = (float)0, Rate = (float)0.03 },

        };
    }
}
