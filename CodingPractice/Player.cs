public class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public Player LevelUp()
    {
        return new Player(Name, Level+1);
    }
 
}



