using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public delegate void EVENT_HANDLER(object sender, EventArgs e);

    public class EVENT_MANAGER
    {
        public event EVENT_HANDLER EVENT;
        List<EVENT_HANDLER> HANDLER;
        int COUNT;

        public EVENT_MANAGER(List<EVENT_HANDLER> events, int event_count)
        {
            
            HANDLER = events;
            COUNT = event_count;

            if(COUNT < 0)
            {
                COUNT = 0;
            }

            for(int i = 0; i < COUNT; i++)
            {
                if(i == 0)
                { 
                    EVENT += HANDLER[i];
                }
                else
                {
                    EVENT -= HANDLER[i - 1];
                    EVENT += HANDLER[i];
                }
                 
                ON_CALL();
            }   
        }

        public void ON_CALL(EventArgs e)  
        {  
            if (EVENT != null)  
            {  
                EVENT(this, e);  
            }  
        }
    }
}