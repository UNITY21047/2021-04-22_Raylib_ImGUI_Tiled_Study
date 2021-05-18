using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    ///<summary>
    ///This static class will control all know entities and 
    ///will load and draw all known entities resources.
    ///</summary>
    public static class entity_manager
    {
        public static List<entity> entities = new List<entity>();
        
        public static List<event_handler> event_handlers = new List<event_handler>();
        public static List<Vector2> sections = new List<Vector2>();
        public static List<Vector2> skill_pairs = new List<Vector2>();
        public static Camera2D camera = new Camera2D();

        public static void init_event_manager()
        {
            //player sectors.
            event_handlers.Add(null);
            event_handlers.Add(null);
            event_handlers.Add(null);
            event_handlers.Add(null);
        }

        public static void insert_entity(entity data, int section)
        {
            if(entities.Count == 0)
            {
                for (int i = 0; i < section + 1; i++)
                {
                    entities.Add(null);
                }
            }
            if(section > entities.Count)
            {
                for(int i = entities.Count; i < section; i++)
                {
                    entities.Add(null);
                }
            }

            entities[section] = data;
        }

        public static void unload_entities()
        {
            for (int i = 0; i < entities.Count; i++)
            {
                try
                {
                    entities[i].unload();
                }
                catch(NullReferenceException e)
                {
                    //Console.WriteLine("OK : " + i +" entity is null.");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: /n" + e);
                }
            }
        }
        
        public static void load_entities(Vector2 camera_offset)
        {
            camera.offset = camera_offset;

            for (int i = 0; i < entities.Count; i++)
            {
                try
                {
                    entities[i].load();
                }
                catch(NullReferenceException e)
                {
                    //Console.WriteLine("OK : " + i +" entity is null.");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: /n" + e);
                }
            }
        }

        public static void draw_entities(Vector2 camera_target, float camera_rotation, float camera_zoom)
        {
            camera.target = camera_target;
            camera.rotation = camera_rotation;
            camera.zoom = camera_zoom;
            
            BeginMode2D(camera);

            for(int i = 0; i < entities.Count; i++)
            {
                try
                {
                    entities[i].draw();
                }
                catch(NullReferenceException e)
                {
                    //Console.WriteLine("OK : " + i +" entity is null.");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: /n" + e);
                }
            }
            
            EndMode2D();
        }
        public static void insert_skill(event_handler event_handle, Vector2 section)
        {
            if(event_handlers.Count == 0)
            {
                for (int i = 0; i < section.Y + 1; i++)
                {
                    event_handlers.Add(null);
                }
            }
            if(section.Y > event_handlers.Count)
            {
                for(int j = event_handlers.Count; j < (int)section.Y; j++)
                {
                    event_handlers.Add(null);
                }
            }

            if(event_handlers[0] == null)
            {
                event_handlers[0] = event_handle;
                event_handlers[3] = event_handle;
            }
            else if(event_handlers[0] != null && event_handlers[1] == null)
            {
                event_handlers[1] = event_handle;
                event_handlers[2] = event_handle;
            }
        }
    }
}