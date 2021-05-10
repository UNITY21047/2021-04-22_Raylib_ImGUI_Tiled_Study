using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class OBJECT
    {
        //Genreal Data
        private String file_name;
        public String FILE_NAME
        {
            get{ return file_name; } 
            set{ file_name = value; }
        }

        private String object_name;
        public String OBJECT_NAME
        {
            get
            {
                return object_name;
            }
            set
            {
                object_name = value;
            }
        }

        private String shape_name;
        public String SHAPE_NAME
        {
            get
            {
                return shape_name;
            }
            set
            {
                shape_name = value;
            }
        }

        //texture_position, texture_name
        private Dictionary<Vector2, int> texture_data_pair;
        public Dictionary<Vector2, int> TEXTURE_DATA_PAIR
        {
            get
            {
                return texture_data_pair;
            }
            set
            {
                texture_data_pair = value;
            }
        }

        float GLOBAL_POSITION;
        int LAYER_POSITION;

        //Dictionary<SKILL_EVENT_ARGUMENTS, String> OBJECT_SKILLS; //SKILL_EVENT_ARGUMENTS, SKILL_NAME
        //List<> OBJECT_EVENTS;the

        bool MULTIPLE_TEXTURES;

        public void SET_OBJECT_PROPERTIES(String file_name, String object_name, Dictionary<Vector2, int> texture_data_pair, float global_postion, int list_position, bool multiple_textures)
        {
            this.FILE_NAME = file_name;
            OBJECT_NAME = object_name;
            TEXTURE_DATA_PAIR = texture_data_pair;
            GLOBAL_POSITION = global_postion;
            LAYER_POSITION = list_position;
            MULTIPLE_TEXTURES = multiple_textures;

            S_OBJECT_LIST.INSERT_OBJECTS(this);
        }

        public void SET_OBJECT_PROPERTIES(String shape_name, String object_name, float global_postion, int list_position)
        {
            SHAPE_NAME = shape_name;
            OBJECT_NAME = object_name;
            GLOBAL_POSITION = global_postion;
            LAYER_POSITION = list_position;

            S_OBJECT_LIST.INSERT_OBJECTS(this);
        }

        public void DRAW()
        {

        }

        public void LOAD()
        {
            if(FILE_NAME != String.Empty)
            {
                
            }
            else if(SHAPE_NAME != String.Empty)
            {
                if(SHAPE_NAME.Equals("ellipse"))
                {
                    
                }
            }
        }
    }
}