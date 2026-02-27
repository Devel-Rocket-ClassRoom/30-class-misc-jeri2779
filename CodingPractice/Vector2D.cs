public class Vector2D
{
    public double X;
    public double Y;

    public Vector2D(double x, double y)
    {
         X = x;
         Y = y;
    }
    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }

    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
}