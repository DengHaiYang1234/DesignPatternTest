using System;
namespace 桥接模式
{
    public class Data : Software
    {
        public override void Run()
        {
            Console.WriteLine("运行日历");
        }
    }
}
