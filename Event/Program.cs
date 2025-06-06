



Player p = new Player();

p.AddPoint();
p.AddPoint();
p.AddPoint();
p.AddPoint();
p.AddPoint();





public class Player
{
    public int Level { get; set; }

    public void AddPoint()
    {
        Level += 10;
        Console.WriteLine($"You Get 10 Point ,Your Level is {Level}");

        if(Level >= 50)
        {
            Console.WriteLine("50");
        }
    }


}