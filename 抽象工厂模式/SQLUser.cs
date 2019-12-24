using System;
namespace 抽象工厂模式
{
    public class SQLUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("数据库,根据id获取user");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("数据库,添加User");
        }
    }
}
