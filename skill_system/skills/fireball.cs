using System;
using System.Numerics;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class fireball
    {
        public fireball(int section_position)
        {
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