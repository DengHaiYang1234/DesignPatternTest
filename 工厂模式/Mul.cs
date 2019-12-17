using System;
namespace 工厂模式
{
    public class Mul : Opeartion
    {
        public override double GetResult()
        {
            return numA * numB;
        }
    }
}
