using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Raylib_cs;


class Program
{
    const int screenWidth = 800;
    const int screenHeight = 600;
    static void Main()
    {

        List<Player> players = new();
        List<Obstacle> obstacles = new();

        Raylib.InitWindow(screenWidth, screenHeight, "Sigma game");

        Player p = new();

        Raylib.SetTargetFPS(60);

        // Spel loop
        while (!Raylib.WindowShouldClose())
        {
            AddBalls(players);
            for (int i = 0; i < players.Count; i++)
            {
                if(players[i].Y > Raylib.GetScreenHeight()) players.RemoveAt(i);
            }
            // System.Console.WriteLine(players.Count);
            players.ForEach(player => player.Update());

                        
            foreach (var player in players)
            {
                foreach (var obstacle in obstacles)
                {
                    if (player.CheckCollision(obstacle))
                    {
                        // Handle collision (e.g., remove player, reduce health, etc.)
                        // System.Console.WriteLine("Collision detected!");
                    }
                }
            }



            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Green);
            players.ForEach(player => player.Draw());
            DrawPyramid(obstacles);
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }

    static void DrawPyramid(List<Obstacle> obstacles)
    {
        int rows = 5;
        int spacing = 100;
        int startX = Raylib.GetScreenWidth() / 2;
        int startY = (Raylib.GetScreenWidth()/2) - 300;

        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int x = startX + (int)((j - i / 2.0f) * spacing);
                int y = startY + i * spacing;
                Obstacle obstacle = new Obstacle { X = (int)x, Y = y };
                obstacles.Add(obstacle);
                obstacle.Draw();
            }
        }
    }

    static void AddBalls(List<Player> players){
        if(Raylib.IsKeyPressed(KeyboardKey.Space)) players.Add(new Player());
    }

}