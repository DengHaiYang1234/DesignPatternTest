using System;
namespace 装饰模式
{
    public class Person
    {
        public Person()
        {

        }

        string name;

        public Person(string name)
        {
            this.name = name;
        }


        public virtual void Show()
        {
            Console.WriteLine("装扮的:{0}", name);
        }

    }
}
