using System;
namespace 工厂方法模式
{
    public class OpeartionAdd : Opeartion
    {


        public override double GetResult()
        {
            return NumA + NumB;
        }
    }
}
