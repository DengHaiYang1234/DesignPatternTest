using System;
/*
装饰模式：动态的给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活。

用处：类似穿衣类代码，就可以形成一个对象链，对于我来说先穿哪件后穿哪件也无所讲究，最终形成整套穿衣风格就好了。
*/

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
