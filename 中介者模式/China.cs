using System;
namespace 中介者模式
{
    public class China : Country
    {
        public China(UnitedNations unitedNations) : base(unitedNations)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("中国接收到的消息：{0}", message);
        }

        public override void SendMessage(string message, Country country)
        {
            unitedNations.SendMessage(message,country);
        }
    }
}
