using System;
namespace 工厂方法模式
{
    public class OpeartionMul : Opeartion
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }
}
