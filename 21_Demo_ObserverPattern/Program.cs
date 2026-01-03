using System.Security.Cryptography.X509Certificates;

namespace _21_Demo_ObserverPattern
{
    public delegate void NotifyEventHandler(string value);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Observer Pattern Demo!!");
            Publisher pub = new Publisher();
            Subcribers sub = new Subcribers();

            pub.Notify+=sub.MethodA;
            pub.Notify+=sub.MethodB;

            pub.notifyEvent("the sale is up to 70%");

            pub.Notify-=sub.MethodB;
            pub.notifyEvent("the 30% of on electronics");
        }

    }

    internal class Subcribers
    {

        public void MethodA(string message)
        {
            Console.WriteLine($"the user recieves the message {message} via mail");
        }

        public void MethodB(string message)
        {
            Console.WriteLine($"the user recieves the message {message} via SMS");
        }
    }

    internal class Publisher
    {
        public event NotifyEventHandler Notify;

        public void notifyEvent(string message)
        {
            Notify?.Invoke(message);  // ?. this operator is used to avoid the null pointer exception
        }

    }
}
