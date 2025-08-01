//using CoffeeShopManager;
//using CoffeeShopManager.Interfaces;

//CoffeeMaker coffeeMaker = new CoffeeMaker();
//InventoryManager inventoryManager = new InventoryManager();
//SalesManager salesManager = new SalesManager();
//ReportGenerator reportGenerator = new ReportGenerator();

//coffeeMaker.MakeCoffee("Espresso");
//inventoryManager.AddInventory("Coffee Beans", 10);
//salesManager.RegisterSale("Espresso", 2);
//reportGenerator.GenerateDailyReport();

//List<IBeverageMaker> beverageMakers = new List<IBeverageMaker>
//{
//    new EspressoMaker(),
//    new TeaMaker(),
//    new ChocolateMaker(),
//};

//foreach (var beverageMaker in beverageMakers)
//{
//    beverageMaker.Prepare();
//}

//Console.ReadKey();

using CoffeeShopManager;
using CoffeeShopManager.Interfaces;

List<ISwitchable> devices = new List<ISwitchable>
{
    new CoffeeMachine(),
    new Oven(),
    new Fridge()
};

foreach (var device in devices)
{
    device.TurnOn();
}

// Uso específico
ICoffeeMaker coffeeMachine = new CoffeeMachine();
coffeeMachine.MakeCoffee();

IBaker oven = new Oven();
oven.Bake();

IRefrigerator fridge = new Fridge();
fridge.Refrigerate();

Console.ReadKey();