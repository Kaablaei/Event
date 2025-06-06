



using System.Drawing;

Player p = new Player();
p.OnAchlievementUnlocked += P_OnAchlievementUnlocked;

void P_OnAchlievementUnlocked(int Point)
{
    Console.WriteLine(Point);
}

p.AddPoint();
p.AddPoint();
p.AddPoint();
p.AddPoint();
p.AddPoint();






public class Player
{
    public int Level { get; set; }


    public delegate void AchlievementUnlocked(int Point);

    public event AchlievementUnlocked? OnAchlievementUnlocked;

    public void AddPoint()
    {
        Level += 10;
        Console.WriteLine($"You Get 10 Point ,Your Level is {Level}");

        if(Level >= 50)
        {
            //Console.WriteLine("50");
            OnAchlievementUnlocked?.Invoke(Level);
        }
    }


}