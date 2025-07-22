namespace CoffeeShopManager;
public class CoffeeShop
{
    public void MakeCoffee(string type)
    { 
        Console.WriteLine($"Making {type} coffee...");
    }

    public void AddInventory(string item, int quantity)
    {
        Console.WriteLine($"Adding {quantity} of {item} to inventory...");
    }

    public void RegisterSale(string item, int quantity)
    {
        Console.WriteLine($"Registering sale of {quantity} {item}(s)...");
    }

    public void GenerateDailyReport()
    {
        Console.WriteLine("Generating daily sales report...");
    }
}

