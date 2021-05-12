using System;
using System.Collections.Generic;
using System.Numerics;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public delegate void event_handler(object sender, EventArgs e);

    public class event_manager
    {
        private static event event_handler handled_event;

        //Make dictionary. 
        public static void process_events(List<event_handler> event_handlers, List<EventArgs> event_arguments, List<Vector2> event_handler_sections, List<Vector2> event_argument_sections)
        {
            //Finish sectioning placement.
            //for(int i = 0; i < count; i++)
            //{
            //    if(i == 0)
            //    { 
            //        handled_event += event_handlers[i];
            //    }
            //    else
            //    {
            //        handled_event -= event_handlers[i - 1];
            //        handled_event += event_handlers[i];
            //    }   
            //    call_handled_event();
            //}   
        }

        public void call_handled_event(EventArgs e)  
        {  
            if (handled_event != null)  
            {  
                handled_event(this, e);  
            }  
        }
    }
}