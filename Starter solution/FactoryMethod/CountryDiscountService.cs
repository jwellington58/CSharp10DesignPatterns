namespace FactoryMethod
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryKeyWord;

        public CountryDiscountService(string countryKeyWord)
        {
            _countryKeyWord = countryKeyWord;
        }

        public override int DiscountPercentage 
        { 
            get 
            {
                return _countryKeyWord switch
                {
                    "BR" => 20,
                    _ => 10,
                };
            }
        }
    }
}
