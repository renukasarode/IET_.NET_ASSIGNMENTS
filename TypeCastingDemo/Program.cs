namespace TypeCastingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, TypeCasting Demo.......");
            int num = 4;
            double num1 = 10.45;

            //Implicit TypeCasting......
            double intToDouble = num;
            Console.WriteLine("In Implicit TypeCasting intToDouble is {0}", intToDouble);

            //Explicit TypeCasting......
            int doubleToInt = Convert.ToInt32(num1);
            Console.WriteLine("In explicit TypeCasting doubleToInt is {0}", doubleToInt);

            Object obj = new object();
            String str = "hello";

            Object strToObj = str;

            //implicit TypeCasting of referenceVariables
            Console.WriteLine("The implicit typeCasting of the referece variables strToObj {0}", strToObj);

            //Explicit TypeCasting of refereceVariables
            //String ?objToString = Convert.ToString(obj);
            String  objToString = Convert.ToString(obj);
            Console.WriteLine("The Explicit typeCasting of the referece variables objToString {0}", objToString);

        }
    }
}
