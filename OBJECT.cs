using System;
using System.Numerics;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class OBJECT
    {
        String FILE_NAME;
        Dictionary<Vector2, int> TEXTURE_DATA_PAIR; //texture_position, texture_name
        float GLOBAL_POSITION;
        int LIST_POSITION;
        //List<> OBJECT_SKILLS;
        //List<> OBJECT_EVENTS;
        bool MULTIPLE_TEXTURES;

        public OBJECT()
        {
            
        }
    }
}