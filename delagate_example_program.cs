    using System;
    using System.Collections.Generic;
    
    public delegate void EVENT_HANDLER(object sender, STRING_EVENT_ARGUMENTS e);

    public class STRING_EVENT_ARGUMENTS : EventArgs  
    {  
        public string STATEMENT;  
    }

    public class INT_EVENT_ARGUMENTS : EventArgs  
    {  
        public int STATEMENT;  
    }

    public class EVENT_MANAGER
    {
        public event EVENT_HANDLER EVENT;
        List<EVENT_HANDLER> HANDLER;
        public EVENT_MANAGER(List<EVENT_HANDLER> events)
        {
            STRING_EVENT_ARGUMENTS EVENT_HANDLER_1 = new STRING_EVENT_ARGUMENTS();   
            EVENT_HANDLER_1.STATEMENT = "Event args for event 1";  

            this.ON_EVENT(EVENT_HANDLER_1);
            HANDLER = events;

            foreach(var item in HANDLER)
            {
                EVENT += item;
            } 
        }

        public void ON_EVENT(STRING_EVENT_ARGUMENTS e)  
        {  
            if (EVENT != null)  
            {  
                EVENT(this, e);  
            }  
        }
    }
    public class main  
    {
        static void Main()  
        {  
            EVENT_MANAGER MAIN = new EVENT_MANAGER(); 
        }

        public void ON_EVENT(object sender, STRING_EVENT_ARGUMENTS e)  
        {  
            Console.WriteLine("I am in OnHandler1 and EVENT_ARGUMENTS is {0}", e.STATEMENT);  
        }
    }  
