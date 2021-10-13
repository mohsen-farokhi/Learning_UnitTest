using System;

namespace TestDoubleSample
{
    public class TaxRepository : ITaxRepository
    {
        public double GetCurrentTaxRate()
        {
            // read from db

            throw new NotImplementedException();

        }
    }
}
