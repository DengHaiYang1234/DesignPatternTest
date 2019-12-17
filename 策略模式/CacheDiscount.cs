using System;
namespace 策略模式
{
    public class CacheDiscount : CashSuper
    {
        float rate = 0.8f;

        public override double GetResult(double totalPrice)
        {
            return totalPrice * rate;
        }
    }
}
