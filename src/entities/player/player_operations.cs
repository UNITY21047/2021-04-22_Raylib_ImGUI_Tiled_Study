using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Numerics;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public static class player_operations
    {
        public static Vector2 player_skill_sector()
        {
            return new Vector2(0, 3);
        }
        public static Vector2 move_player(Vector2 global_position)
        {
            Vector2 position = global_position;

            if(IsKeyDown(KeyboardKey.KEY_UP))
            {
                position -= new Vector2(0, 1);
            }
            if(IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                position += new Vector2(0, 1);
            }
            if(IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                position -= new Vector2(1, 0);
            }
            if(IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                position += new Vector2(1, 0);
            }

            return position;
        }
    }
}