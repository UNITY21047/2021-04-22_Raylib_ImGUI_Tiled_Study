using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    ///<summary>
    ///Entity interface allows drawing and loading of the 
    ///entities property data.
    ///</summary>
    public class entity
    {
        //General Data
        public String file_name;
        public String entity_name;
        public String skill_name;
        public Vector2 global_position;
        public String shape;
        public bool use_default_texture;
        public List<Vector2> texture_sections;
        public Dictionary<Vector2, int> texture_allocation_data;
        public Vector2 skill_pair;

        //Function Data

        ///<summary>
        ///Sets all known entity properties.
        ///</summary>
        public void set_entity_properties(
            String file_name, 
            String entity_name, 
            String skill_name, 
            Vector2 global_position, 
            String shape, 
            bool use_default_texture, 
            List<Vector2> texture_sections, 
            Dictionary<Vector2, int> texture_allocation_data)
        {
            this.file_name = file_name;
            this.skill_name = skill_name;
            this.global_position = global_position;
            this.shape = shape;
            this.use_default_texture = use_default_texture;
            this.texture_sections = texture_sections;
            this.texture_allocation_data = texture_allocation_data;
            entity_manager.insert_entity(this);
        }

        public void draw()
        {
            
        }

        public void load()
        {
            if(!file_name.Equals(String.Empty))
            {
                
            }
        }
    }
}