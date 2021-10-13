namespace TestDoubleSample.Test.Testdoubles
{
    internal class StubTaxRepository : ITaxRepository
    {
        private double _taxRate;

        private StubTaxRepository()
        {
        }

        public static StubTaxRepository CreateNewStub()
        {
            return new StubTaxRepository();
        }

        public StubTaxRepository WhichReturnsTaxRateAs(double taxRate)
        {
            _taxRate = taxRate;
            return this;
        }

        public double GetCurrentTaxRate()
        {
            return _taxRate;
        }
    }
}
