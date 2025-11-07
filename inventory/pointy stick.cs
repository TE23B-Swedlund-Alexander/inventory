


using System.Runtime.CompilerServices;

public class PointyStick : Item
{
    private int MinDmg = Random.Shared.Next(1, 5);
    private int MaxDmg = Random.Shared.Next(10, 15);

    public int drip = Random.Shared.Next(1, 10);

    public int Attack()
    {

        int dmg = Random.Shared.Next(MinDmg, MaxDmg);
        return dmg;
    }
    public void Stats()
    {
        Console.WriteLine($"Dmg: {MinDmg} - {MaxDmg}  ||  drip: {drip}");
    }
}

