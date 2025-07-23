using CoffeeShopManager;
using CoffeeShopManager.Interfaces;

CoffeeMaker coffeeMaker = new CoffeeMaker();
InventoryManager inventoryManager = new InventoryManager();
SalesManager salesManager = new SalesManager();
ReportGenerator reportGenerator = new ReportGenerator();

coffeeMaker.MakeCoffee("Espresso");
inventoryManager.AddInventory("Coffee Beans", 10);
salesManager.RegisterSale("Espresso", 2);
reportGenerator.GenerateDailyReport();

List<IBeverageMaker> beverageMakers = new List<IBeverageMaker>
{
    new EspressoMaker(),
    new TeaMaker(),
    new ChocolateMaker(),
};

foreach (var beverageMaker in beverageMakers)
{
    beverageMaker.Prepare();
}

Console.ReadKey();