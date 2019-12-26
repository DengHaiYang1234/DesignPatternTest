using System;

/*
 * 用一个中介对象来封装一系列的对象交互。中介者使各对象不需要显式地相互引用，从而使其耦合松散，而且可以独立地改变他们之间的交互。
 *
 * 常用于多对一的模式。
 *
 * 中介者模式一般应用于一组对象以定义良好但是复杂的方式进行通信的场合。
 *
 */


namespace 中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNations unitedNations = new UnitedNationsCouncil();

            Country usa = new USA(unitedNations);
            Country china = new China(unitedNations);


            usa.SendMessage("这是美国的消息",china);
            china.SendMessage("这是中国的消息", usa);

        }
    }
}
