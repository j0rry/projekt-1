using Raylib_cs;

class Player
{
    public int Radius = 20;
    public string Name = "Jorry";
    public int X = Raylib.GetScreenWidth() / 2;
    public int Y = 0;
    public Raylib_cs.Color Color = Raylib_cs.Color.Red;
    public int Speed = 5;
    public int Gravity = 9;

    public void Draw() {
        Raylib.DrawCircle(X, Y, Radius, Color);
    }

    public void Update(){
        if(Raylib.IsKeyDown(KeyboardKey.W)) Y -= Speed;
        if(Raylib.IsKeyDown(KeyboardKey.S)) Y += Speed;
        if(Raylib.IsKeyDown(KeyboardKey.A)) X -= Speed;
        if(Raylib.IsKeyDown(KeyboardKey.D)) X += Speed;

        Y += Gravity;
        //Y = Math.Clamp(Y, 0, Raylib.GetScreenHeight() - Radius);

    }

    public bool CheckCollision(Obstacle obstacle)
    {
        int dx = X - obstacle.X;
        int dy = Y - obstacle.Y;
        int distance = (int)Math.Sqrt(dx * dx + dy * dy);

        return distance < (Radius + obstacle.Radius);
    }
}