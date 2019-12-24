using System;
namespace 抽象工厂模式
{
    public class SQLFactory : IFactory
    {
        public IUser CreatDataSystem()
        {
            return new SQLUser();
        }
    }
}
