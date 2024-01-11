public class Point
{
    public int x;
    public int y;

    public Point(int a, int b)
    {
        this.x = a;
        this.y = b;
    }

    public Point add(Point other) {
        int nx = this.x + other.x;
        int ny = this.y + other.y;
        return new Point(nx, ny);
    }

    public Point sub(Point other) {
        int nx = this.x - other.x;
        int ny = this.y - other.y;
        return new Point(nx, ny);
    }

    public override string ToString()
    {
        return "(" + this.x + ", " + this.y + ")";
    }



}