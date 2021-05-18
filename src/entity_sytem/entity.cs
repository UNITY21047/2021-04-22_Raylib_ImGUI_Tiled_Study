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
        public static Vector2 global_position;
        public Rectangle size;
        public String shape;
        Dictionary<Vector2, bool> default_texture;
        public List<Vector2> texture_sections;
        public Dictionary<Vector2, int> texture_allocation_data;
        public Vector2 skill_pair;
        public int entity_sector_postion;

        //Function Data
        Texture2D main_texture;
        Rectangle global_rectangle;
        public Dictionary<String, Vector2> camera_target;

        //Colors: {"Deep Space Sparkle":"586a6a","Little Boy Blue":"71a9f7","Sage":"d0c88e","Coral":"ff8552"}

        ///<summary>
        ///Sets all known entity properties.
        ///</summary>
        public void set_entity_properties(
            String file_name, 
            String entity_name, 
            String skill_name, 
            Vector2 global_position, 
            String shape, 
            Dictionary<Vector2, bool> default_texture,
            List<Vector2> texture_sections, 
            Dictionary<Vector2, int> texture_allocation_data,
            int entity_sector_postion)
        {
            this.file_name = file_name;
            this.skill_name = skill_name;
            this.entity_name = entity_name;
            entity.global_position = global_position;
            this.shape = shape;
            this.default_texture = default_texture;
            this.texture_sections = texture_sections;
            this.texture_allocation_data = texture_allocation_data;
            this.global_rectangle = new Rectangle(entity.global_position.X, entity.global_position.Y, 32f, 64f);
            this.camera_target = new Dictionary<string, Vector2>();
            this.entity_sector_postion = entity_sector_postion;
            camera_target.Add(this.entity_name, entity.global_position);
            entity_manager.insert_entity(this, entity_sector_postion);
        }

        public void draw()
        {
            if(!shape.Equals(String.Empty))
            {
                if(shape.Equals("ellipse"))
                {
                    player.ellipse();
                }
            }
            else if(default_texture[new Vector2(0,0)]) //Gets the default position boolean of this pair.
            {
                DrawTextureRec(main_texture, global_rectangle, global_position, new Color(0x71, 0xa9, 0xf7, 0xff));
            }
        }

        public void load()
        {
            if(!file_name.Equals(String.Empty) && shape.Equals(String.Empty))
            {
                main_texture = LoadTexture(file_name);
            }
            else if(!skill_name.Equals(String.Empty) && shape.Equals(String.Empty))
            {
                if(!file_name.Equals(String.Empty))
                {
                    main_texture = LoadTexture(file_name);
                }
            }
        }

        public void unload()
        {
            UnloadTexture(main_texture);
        }
    }
}