using System;
namespace 抽象工厂模式
{
    public interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
