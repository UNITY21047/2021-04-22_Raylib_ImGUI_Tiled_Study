using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Numerics;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public static class entity_operations
    {
        public static void ellipse(Vector2 position)
        {
            DrawEllipse((int)position.X, (int)position.Y , 32, 64, new Color(0x71, 0xa9, 0xf7, 0xff)); 
        }

        
    }
}