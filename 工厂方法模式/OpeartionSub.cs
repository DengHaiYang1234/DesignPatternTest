using System;
namespace 工厂方法模式
{
    public class OpeartionSub : Opeartion
    {
        

        public override double GetResult()
        {
            return NumA - NumB;
        }
    }
}
