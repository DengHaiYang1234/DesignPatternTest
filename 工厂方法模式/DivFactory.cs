using System;


namespace 工厂方法模式
{
    public class DivFactory : IOpeartionFactory
    {
        public Opeartion CreatOpeartion()
        {
            return new OpeartionDiv();
        }
    }
}
