using System;

namespace Hands_on
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(isEqual("abc", "xyz"));
            Console.WriteLine(isEqual(2,2));

            CalculateSum<int> calculateSum = new CalculateSum<int>();
            Console.WriteLine(calculateSum.add(5, 3));
            

            CalculateSum<double> calculate = new CalculateSum<double>();
            Console.WriteLine(calculate.add(5.6, 9.3));
        }
        //Generic method
        public static bool isEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
    //Generic class
    public class CalculateSum<T> where T: struct
    {
        public T add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }
}