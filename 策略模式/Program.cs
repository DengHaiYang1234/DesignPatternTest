using System;
/*
策略模式：它定了了算法家族，分别封装起来，让它们之间可以互相替换，此模式让算法的变化，不会影响到使用算法的客户。

用处：对简单工厂模式的包装（对算法类的简单包装）。
*/
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
