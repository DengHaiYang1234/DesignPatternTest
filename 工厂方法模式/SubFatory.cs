using System;
namespace 工厂方法模式
{
    public class SubFatory : IOpeartionFactory
    {
        public Opeartion CreatOpeartion()
        {
            return new OpeartionSub();
        }
    }
}
