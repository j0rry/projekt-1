using Raylib_cs;

class Obstacle
{
    public int X;
    public int Y;
    public int Radius = 30;

    public void Draw(){
        Raylib.DrawCircle(X, Y, Radius, Color.Gray);
    }
}