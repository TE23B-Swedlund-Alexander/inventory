PointyStick sword = new PointyStick();

sword.Name = "Swordy";
sword.Weight = 7;
sword.Stats();
Inventory bag = new Inventory();
bag.Store(sword);
bag.takeInventory();
Console.ReadLine();