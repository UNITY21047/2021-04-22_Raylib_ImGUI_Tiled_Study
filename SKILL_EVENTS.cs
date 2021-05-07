using System;
using System.Numerics;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class SKILL_EVENTS
    {
        public SKILL_EVENTS(List<EVENT_HANDLER> list_of_handlers)
        {
            List<EVENT_HANDLER> LIST_OF_HANDLERS = list_of_handlers;

            new EVENT_MANAGER(LIST_OF_HANDLERS, LIST_OF_HANDLERS.Count);
        }
    }
}