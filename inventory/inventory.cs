public class Inventory()
{
    List<Item> Items = [];
    public void Store(Item thing)
    {
        Items.Add(thing);
    }
    public void takeInventory()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine(Items[i].Name);
        }
    }
}