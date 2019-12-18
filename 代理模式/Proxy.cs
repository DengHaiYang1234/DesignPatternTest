using System;
namespace 代理模式
{
    //代理类
    public class Proxy : IGiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGirrl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
