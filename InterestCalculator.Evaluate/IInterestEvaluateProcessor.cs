using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Evaluate
{
    public interface IInterestEvaluateProcessor
    {
        decimal Interest(float balance);
        
    }
}
