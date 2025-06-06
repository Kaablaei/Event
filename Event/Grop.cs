public class Grop
{

    public int GropLevel { get; set; }

    public Grop(Player p)
    {
        p.OnAchlievementUnlocked += P_OnAchlievementUnlocked;
    }




    void P_OnAchlievementUnlocked(int Point)
    {

        GropLevel+=10 ;

    }


}
