using System;
namespace 工厂方法模式
{
    public class AddFactory : IOpeartionFactory
    {
        

        public Opeartion CreatOpeartion()
        {
            return new OpeartionAdd();
        }
    }
}
