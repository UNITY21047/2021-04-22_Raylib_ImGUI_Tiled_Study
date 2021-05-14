using System;
using System.Collections.Generic;
using System.Numerics;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public static class skill_operator
    {
        public static List<event_handler> event_handlers = new List<event_handler>();
        public static List<Vector2> sections = new List<Vector2>();

        public static void load(event_handler event_handle, Vector2 section, int section_position)
        {
            if(event_handlers.Count == 0)
            {
                for (int i = 0; i < section.Y; i++)
                {
                    event_handlers.Add(null);
                }
            }

            if(section.Y > event_handlers.Count)
            {
                for(int j = event_handlers.Count; j < (int)section.Y; j++)
                {
                    event_handlers.Add(null);
                }
            }

            if(event_handlers[section_position] == null)
            {
                event_handlers.Add(event_handle);
            }
            else if(event_handlers[section_position] != null)
            {
                for(int i = (int)section.X; i < (int)section.Y; i++)
                {
                    if(event_handlers[i] == null)
                    {
                        event_handlers.Add(event_handle);
                    }
                }
            }
        }
    }
}