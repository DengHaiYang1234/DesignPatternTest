using System;
namespace 抽象工厂模式
{
    public class User
    {
        string name;
        int id;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
