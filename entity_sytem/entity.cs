using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class entity
    {
        public String file_name;
        public String entity_name;
        public float global_position;
        public List<EventArgs> skills;
        public String entity_shape_name;
        public bool default_texture_switch;
        public List<Vector2> texture_section;
        public Dictionary<Vector2, int> texture_data;

        public void set_entity_properties()
        {
            entity_manager.insert_entity(this);
        }

        public void draw()
        {

        }

        public void load()
        {

        }
    }
}