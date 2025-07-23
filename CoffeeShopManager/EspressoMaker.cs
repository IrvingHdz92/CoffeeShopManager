using CoffeeShopManager.Interfaces;

namespace CoffeeShopManager;

public class EspressoMaker : IBeverageMaker
{
    public void Prepare()
    { 
        Console.WriteLine("Preparing espresso...");
    }
}

