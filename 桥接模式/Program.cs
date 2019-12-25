using System;


/*
 * 将抽象部分与它的实现部分分离，使它们都可以独立地变化。
 *
 *
 * 
 */

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBrand phoneBrand = new PhoneA();
            phoneBrand.InstallationSoftware(new Game());
            phoneBrand.Run();
            phoneBrand.InstallationSoftware(new Data());
            phoneBrand.Run();
        }
    }
}
