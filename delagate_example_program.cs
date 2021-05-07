    using System;
    using System.Collections.Generic;
    
    public delegate void EVENT_HANDLER(object sender, STRING_EVENT_ARGUMENTS e);

    public class STRING_EVENT_ARGUMENTS : EventArgs  
    {  
        public string STATEMENT;  
    }

    public class INT_EVENT_ARGUMENTS : EventArgs  
    {  
        public int NUMBER;  
    }

    public class EVENT_MANAGER
    {
        public event EVENT_HANDLER EVENT;
        List<EVENT_HANDLER> HANDLER;
        int COUNT;

        public EVENT_MANAGER(List<EVENT_HANDLER> events, int event_count)
        {
            STRING_EVENT_ARGUMENTS EVENT_HANDLER_1 = new STRING_EVENT_ARGUMENTS();   

            HANDLER = events;
            COUNT = event_count;

            if(COUNT < 0)
            {
                COUNT = 0;
            }

            for(int i = 0; i < COUNT; i++)
            {
                if(i == 0)
                { 
                    EVENT += HANDLER[i];
                }
                else
                {
                    EVENT -= HANDLER[i - 1];
                    EVENT += HANDLER[i];
                }

                EVENT_HANDLER_1.STATEMENT = "Event args for event" + i;  
                ON_CALL(EVENT_HANDLER_1);
            }   
        }

        public void ON_CALL(STRING_EVENT_ARGUMENTS e)  
        {  
            if (EVENT != null)  
            {  
                EVENT(this, e);  
            }  
        }
    }

    public class main  
    {
        List<EVENT_HANDLER> LIST_OF_HANDLERS = new List<EVENT_HANDLER>();
        //LIST_OF_HANDLERS.Add(new EVENT_HANDLER(ON_EVENT_1));
        //LIST_OF_HANDLERS.Add(new EVENT_HANDLER(ON_EVENT_2));
        //EVENT_MANAGER MAIN = new EVENT_MANAGER(LIST_OF_HANDLERS, LIST_OF_HANDLERS.Count);
    

        public static void ON_EVENT_1(object sender, STRING_EVENT_ARGUMENTS e)  
        {  
            Console.WriteLine("Testing the handler 1: {0}", e.STATEMENT);  
        }
        public static void ON_EVENT_2(object sender, STRING_EVENT_ARGUMENTS e)  
        {  
            Console.WriteLine("Besting the handler 1: {0}", e.STATEMENT);  
        }
    }  
