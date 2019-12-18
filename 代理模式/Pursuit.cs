using System;


namespace 代理模式
{
    //追求者
    public class Pursuit : IGiveGift
    {
        SchoolGirrl mm;
        public Pursuit(SchoolGirrl mm)
        {
            this.mm = mm;
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "送你鲜花");
        }
    }
}
