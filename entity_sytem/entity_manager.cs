using System;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public static class entity_manager
    {
        public static List<entity> entities = new List<entity>();

        public static void insert_entity(entity data)
        {
            entities.Add(data);
        }

        public static void load_entities()
        {
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].load();
            }
        }

        public static void draw_entities()
        {
            for(int i = 0; i < entities.Count; i++)
            {
                entities[i].draw();
            }
        }
    }
}