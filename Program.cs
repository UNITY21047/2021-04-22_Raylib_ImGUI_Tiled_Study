using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {
            //Colors: {"Deep Space Sparkle":"586a6a","Little Boy Blue":"71a9f7","Sage":"d0c88e","Coral":"ff8552"}
            int screen_width = 480;
            int screen_height = 480;

            InitWindow(screen_width, screen_height, String.Empty);

            Vector2 ball_postion = new Vector2((float)screen_width/2, (float)screen_height/2);
            //Shader test_shader = LoadShaderCode(
            //    @"#version 330
//
            //    in vec4 vPosition;
//
            //    void main()
            //    {
            //        gl_Position = vPosition;
            //    }", 
            //    @"#version 330
//
            //    void main()
            //    {
            //        gl_FragColor = vec4(1.0, 1.0, 1.0, 1.0);
            //    }"
            //);
            Shader test_shader = LoadShader(@"/media/pup/storage_1/assets/projects/2021-04-22_Raylib_ImGUI_Tiled_Study/test_shader.vert", @"/media/pup/storage_1/assets/projects/2021-04-22_Raylib_ImGUI_Tiled_Study/test_shader.frag");

            SetTargetFPS(60);

            while (!WindowShouldClose())
            {
                if (IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT)) ball_postion.X += 2.0f;
                if (IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT)) ball_postion.X -= 2.0f;
                if (IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP)) ball_postion.Y -= 2.0f;
                if (IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN)) ball_postion.Y += 2.0f;

                BeginDrawing();

                ClearBackground(Color.WHITE);

                BeginShaderMode(test_shader);
                DrawCircle((int)ball_postion.X, (int)ball_postion.Y, 50, new Color(0x71, 0xa9, 0xf7, 0xff));
                EndShaderMode();
                
                DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

                EndDrawing();
            }

            UnloadShader(test_shader);
            CloseWindow();
        }
    }
}