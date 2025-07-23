using CoffeeShopManager.Interfaces;

namespace CoffeeShopManager;

public class TeaMaker : IBeverageMaker
{
    public void Prepare()
    { 
        Console.WriteLine("Preparing tea...");
    }
}

