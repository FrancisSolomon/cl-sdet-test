using System.Collections.Generic;

namespace Cardlytics.BasicApi.Services
{
    public interface IPrimeFactorsService
    {
        IList<long> CalculatePrimeFactors(long number);
    }
}
