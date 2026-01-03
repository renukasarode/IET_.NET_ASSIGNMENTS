namespace _19_Demo_Events_Delegates
{
    public delegate void MyHandler(int marks);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, from event _delegate Demo!");
            Student std = new Student();

            //std._pass+= new MyHandler(std._passFun);
            //std._fail+=new MyHandler(std._failFun);



            Console.WriteLine("Enter the marks");
            std.marks= Convert.ToInt32(Console.ReadLine());
            std._pass+= new MyHandler(std._passFun);
            std._fail+=new MyHandler(std._failFun);

            std.TriggerEvent();
            ///couplling of event with the delegate 
            //new MyHandler()

        }

        public class Student
        {
            public event MyHandler _pass;
            public event MyHandler _fail;

            private int _marks;

            public int marks
            {

                get
                {
                    return _marks;
                }

                set
                {
                    _marks = value;
                    if(_marks>40)
                    {
                        _pass(_marks);
                    }
                    else
                    {
                        _fail(_marks);
                    }
                }
            }

            public void TriggerEvent()
            {
                if (_marks>40)
                { 
                _pass(_marks);
                }
                else
                {
                    _fail(_marks);
                }
            }

            public void _passFun(int marks)
            {
                Console.WriteLine($"Congratulation!!! you have passed with {marks}");
            }
            public void _failFun(int marks)
            {
                Console.WriteLine($"you have failed with {marks}");
            }
        }
    }
}
