namespace FactoryMethod
{
    /// <summary>
    /// Concrete creator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryKeyWord;

        public CountryDiscountFactory(string countryKeyWord)
        {
            _countryKeyWord = countryKeyWord;
        }

        public override DiscountService CreateDiscountService()
            => new CountryDiscountService(_countryKeyWord);
    }
}
