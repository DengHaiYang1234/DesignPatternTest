using System;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小明");

            Console.WriteLine("打扮：");

            BigTrouser kk = new BigTrouser();
            TShirts ts = new TShirts();

            kk.Decorate(xc);
            ts.Decorate(kk);
            ts.Show();
        }
    }
}
