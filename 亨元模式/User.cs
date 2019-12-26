using System;
namespace 亨元模式
{
    public class User
    {
        string name;

        public User(string name)
        {
            this.name = name;

        }

        public string Name { get { return name; } set { name = value; } }
    }
}
