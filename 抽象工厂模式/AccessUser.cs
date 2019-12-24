using System;
namespace 抽象工厂模式
{
    public class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("Access,根据id获取user");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Access,添加User");
        }
    }
}
