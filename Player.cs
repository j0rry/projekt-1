using Raylib_cs;

class Player
{
    public int Radius = 20;
    public string Name = "Jorry";
    public int x = Raylib.GetScreenWidth();
    public int y = Raylib.GetScreenHeight() / 2;
    public Raylib_cs.Color Color = Raylib_cs.Color.Red;

    public void Draw() {
        Raylib.DrawCircle(x, y, Radius, Color);
    }
}