using System;

/*
工厂方法模式：定义一个用于创建对象的接口，让子类决定实例化哪一个个类，工厂方法使一个类的实例化延迟到其子类。

用处：若需可扩展计算类，只需要添加一个Operation和一个OpeartionFactory类就可以。剩下的只需交由客户端处理即可。对扩展开放，对修改关闭
*/

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IOpeartionFactory factory = new AddFactory();
            Opeartion oper = factory.CreatOpeartion();

            oper.NumA = 10;
            oper.NumB = 20;

            

            Console.WriteLine(oper.GetResult());
        }
    }
}
