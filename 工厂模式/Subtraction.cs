using System;
namespace 工厂模式
{
    public class Subtraction : Opeartion
    {
        public override double GetResult()
        {
            return numA - numB;
        }
    }
}
