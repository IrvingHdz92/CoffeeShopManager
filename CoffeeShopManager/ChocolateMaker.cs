using CoffeeShopManager.Interfaces;

namespace CoffeeShopManager;

public class ChocolateMaker : IBeverageMaker
{
    public void Prepare()
    {
        Console.WriteLine("Preparing chocolate...");
    }
}

