public abstract class Ship
{
    /// <summary>
    /// The row (0 to 9) which contains the bow (front) of the ship.
    /// </summary>
    public int BowRow { get; set; }
    
    /// <summary>
    /// The column (0 to 9) which contains the bow (front) of the ship.
    /// </summary>
    public int BowColumn { get; set; }

    /// <summary>
    /// The number of squares occupied by the ship. 
    /// </summary>
    public int Length { get; protected set; }
    
    /// <summary>
    /// An array of booleans telling whether that part of the ship has been hit.
    /// </summary>
    public bool[] Hit { get; protected set; }
    
    /// <summary>
    /// True if the ship occupies a single row, false otherwise.
    /// </summary>
    public bool IsHorizontal { get; set; }
    
    /// <summary>
    /// Name of the ship type.
    /// </summary>
    public abstract string ShipType { get; }
}