using CoffeeShopManager;

CoffeeMaker coffeeMaker = new CoffeeMaker();
InventoryManager inventoryManager = new InventoryManager();
SalesManager salesManager = new SalesManager();
ReportGenerator reportGenerator = new ReportGenerator();

coffeeMaker.MakeCoffee("Espresso");
inventoryManager.AddInventory("Coffee Beans", 10);
salesManager.RegisterSale("Espresso", 2);
reportGenerator.GenerateDailyReport();