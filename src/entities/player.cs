using System;
using System.Numerics;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class player : entity
    {
        fireball fireball_entity;
        public player()
        {
            fireball_entity = new fireball();
            set_entity_properties(
                null, 
                "player one", 
                null, 
                new Vector2(0, 0),
                "ellipse",
                true,
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