using CoffeeShopManager.Interfaces;

namespace CoffeeShopManager;

public class Oven : ISwitchable, IBaker
{
    public void TurnOn() => Console.WriteLine("Oven is now ON.");
    public void TurnOff() => Console.WriteLine("Oven is now OFF.");
    public void Bake() => Console.WriteLine("Baking items in the oven...");
}
