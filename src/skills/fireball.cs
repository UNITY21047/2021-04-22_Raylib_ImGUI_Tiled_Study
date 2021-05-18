using System;
using System.Numerics;
using Raylib_cs;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class fireball : entity
    {
        public fireball()
        {   
            entity_manager.insert_skill(new event_handler(trigger), player.player_skill_sector());
        }

        public void trigger(object sender)
        {
            //set_entity_properties();
        }
    }
}