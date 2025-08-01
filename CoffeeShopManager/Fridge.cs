using CoffeeShopManager.Interfaces;

namespace CoffeeShopManager;

public class Fridge : ISwitchable, IRefrigerator
{
    public void TurnOn() => Console.WriteLine("Fridge is now ON.");
    public void TurnOff() => Console.WriteLine("Fridge is now OFF.");
    public void Refrigerate() => Console.WriteLine("Fridge is refrigerating items.");
}
