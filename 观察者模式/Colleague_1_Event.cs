using System;
namespace 观察者模式
{
    public class Colleague_1_Event : Observer_Event
    {
        public Colleague_1_Event(string name) : base(name)
        {

        }

        public void Update1()
        {
            Console.WriteLine("{0}的事件实现啊", name);
        }
    }
}
