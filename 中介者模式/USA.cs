using System;
namespace 中介者模式
{
    public class USA : Country
    {
        public USA(UnitedNations unitedNations) : base(unitedNations)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("美国接收到的消息：{0}", message);
        }

        public override void SendMessage(string message, Country country)
        {
            unitedNations.SendMessage(message, country);
        }
    }
}
