using System;
using System.Numerics;
using Raylib_cs;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {
            int screen_width = 480;
            int screen_height = 480;

            Raylib.InitWindow(screen_width, screen_height, String.Empty);

            Vector2 ball_postion = new Vector2((float)screen_width/2, (float)screen_height/2);

            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT)) ball_postion.X += 2.0f;
                if (Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT)) ball_postion.X -= 2.0f;
                if (Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP)) ball_postion.X -= 2.0f;
                if (Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN)) ball_postion.X += 2.0f;

                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}