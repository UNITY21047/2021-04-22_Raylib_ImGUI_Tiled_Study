using System;
using System.Numerics;
using Raylib_cs;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class fireball : entity
    {
        private int count = 0;
        private entity fireball_entity;

        public fireball()
        {   
            if (true)
            {
                
            }

            if(entity_manager.event_handlers[0] != null)
            {
                skill_pair = new Vector2(0, 3);
                entity_manager.load_skill(new event_handler(trigger), player.player_skill_sector(), 0);
                entity_manager.load_skill(new event_handler(trigger), player.player_skill_sector(), 3);
            }
            else if(entity_manager.event_handlers[1] != null)
            {
                skill_pair = new Vector2(1, 2);
                entity_manager.load_skill(new event_handler(trigger), player.player_skill_sector(), 1);
                entity_manager.load_skill(new event_handler(trigger), player.player_skill_sector(), 2);
            }
        }

        public void trigger(object sender)
        {
            //set_entity_properties();
        }
    }
}