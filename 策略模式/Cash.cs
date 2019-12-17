using System;
namespace 策略模式
{
    public class Cash
    {
        CashSuper cs;

        public Cash(string type)
        {
            switch(type)
            {
                case "正常":
                    cs = new CashNormal();
                    break;
                case "打折":
                    cs = new CacheDiscount();
                    break;
                case "满300减100":
                    cs = new CacheDiscount();
                    break;
            }
        }

        public double GetResult(double totalPrice)
        {
            return cs.GetResult(totalPrice);
        }
    }
}
