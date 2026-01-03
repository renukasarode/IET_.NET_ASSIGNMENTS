using System;
using System.ComponentModel;

namespace _20_Demo_MultiCastEvents
{
    public delegate void MyEventHandler();
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,from MultiCast Events!");
            Console.WriteLine("is Guest Arrived y/n?");
            
            string isGuestArrived = Console.ReadLine();
            MyCollegeEvent coll = new MyCollegeEvent();
            MyEventHandler handler = coll.Welcome;
            handler+=coll.WelcomeSpeech;
            if (isGuestArrived=="y")
                handler+=coll.GuestSpeech;
            else
                handler-=coll.GuestSpeech;

            handler+=coll.Dance;
            handler+=coll.Dinner;
            handler+=coll.WrappUp;

            handler();
        }
    }

    internal class MyCollegeEvent
    {
        public void Welcome()
        {
            Console.WriteLine("welcome to the function");
        }

        public void WelcomeSpeech()
        {
            Console.WriteLine("Host blah blah blah!!!!");
        }

        public void GuestSpeech()
        {
            Console.WriteLine("Guest blah blah blah!!!!");
        }
        public void Dance()
        {
            Console.WriteLine("Dance from students");
        }

        public void Dinner()
        {
            Console.WriteLine("Enjoy the dinner");
        }

        public void WrappUp()
        {
            Console.WriteLine("Bye Bye....");
        }
    }
}
