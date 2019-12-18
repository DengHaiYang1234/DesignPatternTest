using System;
namespace 工厂方法模式
{
    public class OpeartionDiv : Opeartion
    {
        public override double GetResult()
        {
            return NumA / NumB;
        }
    }
}
