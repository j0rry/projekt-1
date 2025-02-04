using System.Text.Json;
using Raylib_cs;


class Program
{
    static void Main()
    {
        Player p = new Player {x = 100, y = 100};

        const int screenWidth = 800;
        const int screenHeight = 600;

        Raylib.InitWindow(screenWidth, screenHeight, "Sigma game");

        Raylib.SetTargetFPS(60);

        // Spel loop
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Green);
            p.Draw();
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}