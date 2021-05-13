using System;
using System.Collections.Generic;
using System.Numerics;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public delegate void event_handler(object sender);

    public class event_manager
    {
        private event event_handler handled_event;

        //Make dictionary. 
        public event_manager()
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

        public void add_event_handler(event_handler handler)
        {
            handled_event += handler;
        }
        
        public void remove_event_handler(event_handler handler)
        {
            handled_event -= handler;
        }

        public void call_handled_event(object sender)  
        {  
            if (handled_event != null)  
            {  
                handled_event(this);  
            }  
        }
    }
}