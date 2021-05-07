    using System;
    
    public delegate void MyHandler1(object sender, MyEventArgs e);   

    public class MyEventArgs : EventArgs  
    {  
        public string m_id;  
    }

    public class main
    {
        public static event MyHandler1 Event1;
        public main()
        {
            MyHandler1 d1 = new MyHandler1(OnHandler1);
            Event1 += d1;  
            MyEventArgs e1 = new MyEventArgs();   
            e1.m_id = "Event args for event 1";  
            this.FireEvent1(e1);
        }

        public void FireEvent1(MyEventArgs e)  
        {  
            if (Event1 != null)  
            {  
                Event1(this, e);  
            }  
        }

        public void OnHandler1(object sender, MyEventArgs e)  
        {  
            Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id);  
        }
    }
    public class Driver  
    {  
        public static event MyHandler1 Event1;

        static void Main()  
        {  
            main MAIN = new main();  
        }  
    }  
