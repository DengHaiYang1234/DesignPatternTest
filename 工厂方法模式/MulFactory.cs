using System;
namespace 工厂方法模式
{
    public class MulFactory : IOpeartionFactory
    {
        public Opeartion CreatOpeartion()
        {
            return new OpeartionMul();
        }
    }
}
