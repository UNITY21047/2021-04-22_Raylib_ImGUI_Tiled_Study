using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class program
    {
        public static void Main()
        {
            int width = GetScreenWidth();
            int height = GetScreenHeight();

            InitWindow(width, height, String.Empty);

            ToggleFullscreen();

            SetTargetFPS(60);

            while(!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(new Color(0x58, 0x6a, 0x6a, 0xff));
                EndDrawing();
            }

            CloseWindow();
        }
    }
}