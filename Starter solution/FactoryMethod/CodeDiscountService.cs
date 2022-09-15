namespace FactoryMethod
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly string _code;

        public CodeDiscountService(string code)
        {
            _code = code;
        }

        public override int DiscountPercentage { get => 15; }
    }
}
