using System;
namespace 桥接模式
{
    public class PhoneB : PhoneBrand
    {
        public override void Run()
        {
            Console.WriteLine("手机B");
            software.Run();
        }
    }
}
