using System.Linq;

public class Battlefield
{
    private readonly Ship[,] ships;

    public Battlefield(Ship[,] ships)
    {
        this.ships = ships;
    }
}