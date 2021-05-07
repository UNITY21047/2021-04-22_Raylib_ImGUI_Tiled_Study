using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class OBJECT
    {
        String FILE_NAME;
        Dictionary<Vector2, int> TEXTURE_DATA_PAIR; //texture_position, texture_name
        float GLOBAL_POSITION;
        int LIST_POSITION;
        //Dictionary<SKILL_EVENT_ARGUMENTS, String> OBJECT_SKILLS; //SKILL_EVENT_ARGUMENTS, SKILL_NAME
        //List<> OBJECT_EVENTS;the 

        public OBJECT(String file_name, Dictionary<Vector2, int> texture_data_pair, float global_postion, int list_position, bool multiple_textures)
        {
            
        }
    }
}