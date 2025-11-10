public class Armor : Item
{
   private float Protection = Random.Shared.Next(5,12);
   private int drip =Random.Shared.Next(1,10);

    public void Stats()
    {
        Console.WriteLine($"{getname()} armor rating: {Protection}  ||  drip: {drip} || weight {getweight}");
    }
}
