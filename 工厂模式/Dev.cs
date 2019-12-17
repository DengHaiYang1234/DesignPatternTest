using System;
namespace 工厂模式
{
    public class Dev : Opeartion
    {
        public override double GetResult()
        {
            return numA / numB;
        }
    }
}
