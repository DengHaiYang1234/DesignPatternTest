using System;
namespace 桥接模式
{
    public class PhoneA : PhoneBrand
    {
        public override void Run()
        {
            Console.WriteLine("手机A");
            software.Run(); 
        }
    }
}
