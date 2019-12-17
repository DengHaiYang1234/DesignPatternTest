using System;
namespace 策略模式
{
    public class CashNormal : CashSuper
    {
        public override double GetResult(double totalPrice)
        {
            return totalPrice;
        }

    }
}
