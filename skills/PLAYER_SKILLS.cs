using System;
using System.Collections.Generic;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class SKILL_FIRE_BALL : EventArgs
    {
        public SKILL_FIRE_BALL()
        {
            TRIGGER.LOAD(this);
        }

        public void ACTIVATE()
        {
            
        }
    }

    public static class TRIGGER
    {
        public static List<EventArgs> SKILLS = new List<EventArgs>(); 
        public static void LOAD(EventArgs argument)
        {
            SKILLS.Add(argument);
        }
    }
}