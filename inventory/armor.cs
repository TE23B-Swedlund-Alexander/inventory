public class Armor : Item
{
   public float Protection = Random.Shared.Next(5,12);
   public int drip =Random.Shared.Next(1,10);

    public void Stats()
    {
        Console.WriteLine($"armor rating: {Protection}  ||  drip: {drip}");
    }
}
