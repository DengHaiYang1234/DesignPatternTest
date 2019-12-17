using System;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cash cash = new Cash("满300减100");
            int num = 10;
            double price = 40.0f;

            Console.WriteLine(cash.GetResult((double)(num * price)));
        }
    }
}
