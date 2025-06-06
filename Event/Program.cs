



using System.Drawing;
using System.Reflection.Emit;

Player p = new Player();
p.OnAchlievementUnlocked += P_OnAchlievementUnlocked;

p.LevelChange += P_OnLevelChangeHandler;

void P_OnLevelChangeHandler(object sender, LevelChangeEventArgs e)
{
    Console.WriteLine($"You Get {e.NewPoint} Point ,Your Level is {e.TotalPoint}");

}

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


    //public delegate void LevelChangeHandler(object sender, LevelGangeEventArgs e);
    //public event LevelChangeHandler? OnLevelChangeHandler;

    public event EventHandler<LevelChangeEventArgs>? LevelChange;


    public void AddPoint()
    {
        Level += 10;
        //Console.WriteLine($"You Get 10 Point ,Your Level is {Level}");
        LevelChange?.Invoke(this,new LevelChangeEventArgs(10,Level));

        if (Level >= 50)
        {
            //Console.WriteLine("50");
            OnAchlievementUnlocked?.Invoke(Level);
        }
    }


}


public class LevelChangeEventArgs : EventArgs
{
    public int NewPoint {  get;  }
    public int TotalPoint { get;  }

    public LevelChangeEventArgs(int newpoint, int totalpoint)
    {
        NewPoint = newpoint;
        TotalPoint = totalpoint;
    }
}