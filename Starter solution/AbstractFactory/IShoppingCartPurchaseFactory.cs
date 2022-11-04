namespace AbstractFactory
{
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostsService CreateShoppingCostsService();
    }
}
