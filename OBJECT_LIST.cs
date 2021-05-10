using System;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public static class S_OBJECT_LIST
    {
        public static List<OBJECT> OBJECT_LIST = new List<OBJECT>();

        public static void INSERT_OBJECTS(OBJECT data)
        {
            
        }

        public static void LOAD_OBJECTS()
        {
            for (int i = 0; i < OBJECT_LIST.Count; i++)
            {
                OBJECT_LIST[i].LOAD();
            }
        }

        public static void DRAW_OBJECTS()
        {
            for(int i = 0; i < OBJECT_LIST.Count; i++)
            {
                OBJECT_LIST[i].DRAW();
            }
        }

        public static void SWITCH_OBJECT_POSITION()
        {

        }
    }
}