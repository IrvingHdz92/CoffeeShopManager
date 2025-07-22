namespace CoffeeShopManager;
public class SalesManager
{
    public void RegisterSale(string item, int quantity)
    {
        Console.WriteLine($"Registering sale of {quantity} {item}(s)...");
    }
}

