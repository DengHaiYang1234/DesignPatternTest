using System;
namespace 亨元模式
{
    public class ConcreteWebSite : WebSite
    {
        string name = "";

        public ConcreteWebSite(string name,int num)
        {
            this.name = name;
            testNum = num;
        }

        public override void GetUser()
        {
            Console.WriteLine("当前的user：" + currentUser.Name);
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + name + "用户：" + user.Name);
            currentUser = user;
        }


    }
}
