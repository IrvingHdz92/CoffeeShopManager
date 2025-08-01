using CoffeeShopManager.Interfaces;

namespace CoffeeShopManager;

public class CoffeeMachine : ISwitchable, ICoffeeMaker
{
    public void TurnOn() => Console.WriteLine("Coffee Machine is now ON.");
    public void TurnOff() => Console.WriteLine("Coffee Machine is now OFF.");
    public void MakeCoffee() => Console.WriteLine("Making coffee...");    
}

