PointyStick sword = new PointyStick();
Consumable potion = new Consumable();
Armor helmet = new Armor();
sword.Nameing("Sword");
sword.wheiging  (7);
sword.Stats();
potion.setUses (1);
potion.Nameing ("Health Potion");
potion.wheiging(1);
helmet.Nameing("helmet");
helmet.wheiging  (5);
Inventory bag = new Inventory();
bag.Store(sword);
bag.Store(potion);
bag.takeInventory();
Console.ReadLine();

Console.WriteLine(helmet.getname);
helmet.Stats();
Console.WriteLine($"do you want da {helmet.getname} y/n");
string Y = Console.ReadLine();
if (Y == "y")
{
    bag.Store(helmet);
    bag.takeInventory();
}
else
{
    Console.WriteLine("you left the helmet");
}
Console.ReadLine();


