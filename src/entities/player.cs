using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class player : entity
    {
        fireball fireball_entity;
        Dictionary<Vector2, bool> texture_default;
        public player()
        {
            fireball_entity = new fireball();
            texture_default = new Dictionary<Vector2, bool>();

            texture_default.Add(new Vector2(0f, 0f), false);
            set_entity_properties(
                String.Empty, 
                "player one", 
                String.Empty, 
                new Vector2(GetScreenWidth()/2, GetScreenHeight()/2),
                "ellipse",
                texture_default,
                null,
                null,
                2);
        }

        public static Vector2 player_skill_sector()
        {
            return new Vector2(0, 3);
        }

        public static Vector2 move_player()
        {
            if(IsKeyDown(KeyboardKey.KEY_UP)) return global_position -= new Vector2(0, 1);
            if(IsKeyDown(KeyboardKey.KEY_DOWN)) return global_position += new Vector2(0, 1);
            if(IsKeyDown(KeyboardKey.KEY_LEFT)) return global_position -= new Vector2(1, 0);
            if(IsKeyDown(KeyboardKey.KEY_RIGHT)) return global_position += new Vector2(1, 0);
            return global_position += new Vector2(0, 0);
        }
        public static void ellipse()
        {
            DrawEllipse((int)move_player().X, (int)move_player().Y , 32, 64, new Color(0x71, 0xa9, 0xf7, 0xff)); 
        }
    }
}