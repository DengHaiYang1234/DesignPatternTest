using System;
namespace 策略模式
{
    public class CacheRebate : CashSuper
    {
        double basePrice = 300f;
        double rebateNumbber = 100f;

        public override double GetResult(double totalPrice)
        {
            if(totalPrice >= basePrice)
            {
                return totalPrice - rebateNumbber;
            }

            return totalPrice;
        }
    }
}
