public class ImmutableCircle
{
    public int Radius { get; set; }

    public ImmutableCircle(int radius)
    {
        Radius = radius;
    }
    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}

