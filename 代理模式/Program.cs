using System;

/*
代理模式：为其它对象提供一种代理以控制对这个对象的访问。


用处：计算真实对象的引用次数，当对象没有引用使，可以自动释放它。
*/

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirrl schoolGirrl = new SchoolGirrl();
            schoolGirrl.Name = "娇娇";

            Proxy daili = new Proxy(schoolGirrl);
            daili.GiveFlowers();
            daili.GiveDolls();
            daili.GiveChocolate();
        }
    }
}
