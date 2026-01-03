using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _37_Demo_CsharpFeatures
{
    //public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());

            #region old way to bind the method
            //MyDelegate del = new MyDelegate(Check);
            //bool status = del(num);
            //if (status)
            //{
            //    Console.WriteLine("The number is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("The number is less than 10");
            //}
            #endregion

            #region MyAnnonymous function with delegate keyword
            //Console.WriteLine("using the annonymous function and delegate keyword");
            //MyDelegate del1 = new MyDelegate(delegate (int num) { return num>10; });
            //MyDelegate del2 = delegate (int num)
            //{
            //    return num>10;
            //};
            //bool status1 = del2(num);
            //if (status)
            //{
            //    Console.WriteLine("The number is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("The number is less than 10");
            //}
            #endregion

            #region Lambda Expression
            //Console.WriteLine("using the lambda expressions");

            //MyDelegate del3 = (int num) =>
            //{
            //    return num>10;
            //};

            //MyDelegate del4 = num => num>10;
            //del4(num);
            //bool status4 = del4(num);
            //if (status4)
            //{
            //    Console.WriteLine("The number is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("The number is less than 10");
            //}

            #endregion

            #region Predicate a inBuilt Delegate
            //  Console.WriteLine("Using the predicate delegate");
            //  Predicate<int> del5 = num => num>10;  // No need to define the user defined delegate
            //bool status5 = del5(num);
            //  if (status5)
            //  {
            //      Console.WriteLine("The number is greater than 10");
            //  }
            //  else
            //  {
            //      Console.WriteLine("The number is less than 10");
            //  }
            #endregion

            #region in-Built Sum Extension method and udf MySum method

            // int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum =  arr.Sum();
            // Console.WriteLine($"the sum is {sum}");

            // //int sum1 = MySum(arr);
            // //Console.WriteLine($"the sum is {sum1}");
            // Console.WriteLine("this is using the custom MySum() extension method");
            // var sum1 = arr.MySum<int>(5);
            // Console.WriteLine($"the sum is {sum1}");
            // Console.WriteLine("Enter any value of int type");
            // int something = Convert.ToInt32(Console.ReadLine());    
            // string[] strArr = { "hello", "from", "IET Batch2025" };
            // string sumStr =  strArr.MySum<string>(something);
            // Console.WriteLine($"the concated strings are:{sumStr}");
            #endregion

            #region CheckForValid EmailID

            //Console.WriteLine("Enter the Email ID");
            //string? email = Console.ReadLine();
            //if(email!=null)
            //{
            //   bool stat1 = email.CheckValidateEmailId();
            //    if (stat1)
            //    {
            //        Console.WriteLine("it is the valid email");
            //    }
            //    else
            //    {
            //        Console.WriteLine("it is not the valid email");
            //    }

            //}
            #endregion

            #region Convert TO List Extension Method

            // int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            // List<int> myList1 = arr.ConvertToList<int>(1111);
            // foreach (int item in myList1)
            // {
            //     Console.WriteLine(item);
            // }

            // string[] strArr = { "Renuka", "Gajanan", "Sarode" };
            //List<string> strList =  strArr.ConvertToList<string>(12345);
            // foreach(string item in strList) 
            //     {
            //     Console.WriteLine(item);
            //     }

            #endregion

            #region MyCustomCollection 
            MyCustomCollection myCollectionObj = new MyCustomCollection();
            myCollectionObj.addElement(4);
            myCollectionObj.addElement(45);
            myCollectionObj.addElement(54);
            myCollectionObj.addElement(5);

           ArrayList MyArrList =   myCollectionObj.getArrList;
            foreach (int item in MyArrList)
            {
                Console.WriteLine(item);
            }

            foreach (int item in myCollectionObj)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region MyCustomCollection Of String

            MyCollection collection = new MyCollection();
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
            #endregion

        }

        public static bool Check(int num)
        {
            return num>10;
        }

        //public static T MySum<T>(this IEnumerable<T> arr)
        //{
        //    dynamic sum = 0;
        //    foreach (T item in arr) 
        //        {
        //         sum+= item;
        //        }
        //    return sum;
        //}
    }

    internal class MyCollection : IEnumerable
    {
        private string[] strArr = { "Mon", "Tue", "Wed", "Thu", "Fri","Sun"};

        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<strArr.Count();i++)
            {
                yield return strArr[i];
            }
        }
    }

    internal class MyCustomCollection : IEnumerable
    {
        private ArrayList arr = new ArrayList();
         public ArrayList getArrList
        {
            get
            {
                return arr;
            }
        }

        public void addElement(int element)
        {
            arr.Add(element);
        }

        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<arr.Count;i++)
            {
               yield return arr[i];
            }
        }
    }

    public static class MyClass //: IEnumerable<int>
    {
        public static T MySum<T>(this IEnumerable<T> arr,int something)
        {
            dynamic sum = 0;
            foreach (T item in arr)
            {
                sum+= item;
            }
            Console.WriteLine($"the Something is {something}");
            return sum;
        }

        public static bool CheckValidateEmailId(this string email)
        {
           return email.Contains("@b.com");

        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> arr, int val)
        {
            List<T> MyList = new List<T>();
            foreach (T item in arr)
            {
                MyList.Add(item); 
            }
            Console.WriteLine($"the passed Parameter is {val}");
            return MyList;
        }
    }
}

