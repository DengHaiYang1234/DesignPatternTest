using System;
namespace 抽象工厂模式
{
    public class AccessFactory : IFactory
    {
        public IUser CreatDataSystem()
        {
            return new AccessUser();
        }
    }
}
