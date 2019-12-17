using System;
namespace 装饰模式
{
    public class TShirts : Finery
    {
        public TShirts()
        {

        }

        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
}
