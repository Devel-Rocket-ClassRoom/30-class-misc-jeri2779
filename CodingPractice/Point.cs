class Point
{
    readonly int X;
    readonly int Y;
    public Point(int x,int y)
    {
        X = x;
        Y = y;
    }

    public Point MoveBy(int dx, int dy)
    {
        return new Point(X + dx, Y + dy);
    }
    public override string ToString()
    {
        return $"{X}, {Y}";
    }
}
