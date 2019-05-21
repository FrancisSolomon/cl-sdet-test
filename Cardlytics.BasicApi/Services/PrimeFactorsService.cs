using System;
using System.Collections.Generic;

namespace Cardlytics.BasicApi.Services
{
    public class PrimeFactorsService : IPrimeFactorsService
    {
        public IList<long> CalculatePrimeFactors(long number)
        {
            IList<long> primeFactors = new List<long>();

            if (number % 2 == 0)
            {
                primeFactors.Add(2);
                number = number / 2;
            }

            for (var i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    primeFactors.Add(i);
                    number = number / i;
                }
            }

            return primeFactors;
        }
    }
}
