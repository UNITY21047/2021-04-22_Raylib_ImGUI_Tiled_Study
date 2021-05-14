using System;
using System.Numerics;
using Raylib_cs;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class fireball : skill
    {
        public fireball()
        {
            name = "fireball";
            
            if (true)
            {
                
            }

            skill_pair = new Vector2();
            skill_operator.load(new event_handler(trigger), skill_sector(), section_position);
        }

        public void trigger(object sender)
        {
            
        }

        public Vector2 skill_sector()
        {
            return new Vector2(0, 3);
        }
    }
}