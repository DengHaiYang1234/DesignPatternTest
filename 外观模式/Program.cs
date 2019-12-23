using System;
/*
 *
 * 为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口使得这一子系统更易使用
 *
 * 用处：对一些不通用的类，但需要组合使用一些方法的时候，可以用。

*/

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }
}
