using System;
namespace 装饰模式
{
    public class BigTrouser : Finery
    {
        public BigTrouser()
        {
        }

        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
}
