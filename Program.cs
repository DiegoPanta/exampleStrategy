namespace exampleStrategy;

class Program
{
    static void Main(string[] args)
    {
        decimal originalPrice = 100.0m;

        IDiscountStrategy defaultDiscount = new DefaultDiscountBusiness();
        Order orderWithDefaultDiscount = new Order(defaultDiscount);
        Console.WriteLine($"Price with default discount: {orderWithDefaultDiscount.CalculatePriceWithDiscount(originalPrice)}");

        IDiscountStrategy vipDiscount = new VIPDiscountBusiness();
        Order orderWithVIPDiscount = new Order(vipDiscount);
        Console.WriteLine($"Price with VIP discount: {orderWithVIPDiscount.CalculatePriceWithDiscount(originalPrice)}");

    }
}
