using System;
using System.Collections.Generic;
using System.Numerics;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public static class skill_operator
    {
        public static List<EventArgs> arguments = new List<EventArgs>();
        public static List<event_handler> event_handlers = new List<event_handler>();

        public static void load_argument(EventArgs argument, Vector2 section)
        {
            arguments.Add(argument);
        }

        public static void load_event_handler(event_handler handler, Vector2 section)
        {
            event_handlers.Add(handler);
        }
    }
}