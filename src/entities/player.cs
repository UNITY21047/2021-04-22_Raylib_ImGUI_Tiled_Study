using System;
using System.Numerics;
using System.Collections.Generic;

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
                new Vector2(0, 0),
                "ellipse",
                texture_default,
                null,
                null);
        }

        public static Vector2 player_skill_sector()
        {
            return new Vector2(0, 3);
        }

        public Vector2 move_player()
        {
            return new Vector2(0, 0);
        }
    }
}