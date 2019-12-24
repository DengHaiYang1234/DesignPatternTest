using System;

/*
 *抽象工厂模式：提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
 * 多用于需要对功能类起到能够快速切换
 */

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ////抽象工厂模式。举例是用SQL和Access两个数据库。劣势：当增加类似user模块的时候时，会不断扩展类，且若有多个地方引用user，需要不断初始化。
            ////该模式也可利用简单工厂模式进行改装，去掉IFactory接口及其继承类。新建一个factory类，利用siwth方法来创建具体的数据库对象
            //User user = new User();
            //IFactory factory = new SQLFactory();
            //IUser sqlUser = factory.CreatDataSystem();

            //sqlUser.Insert(user);
            //sqlUser.GetUser(0);

            //利用反射解决实例化过多且分散不易管理的问题
            User user = new User();
            IUser userIn = DataAccess.CreatUser();
            userIn.Insert(user);
            userIn.GetUser(0);
        }
    }
}
