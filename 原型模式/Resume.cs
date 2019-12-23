using System;

//正常模式
namespace 原型模式
{
    public class Resume : ICloneable
    {
        string name;
        string sex;
        string age;
        string timeArea;
        string company;

        public Resume(string name)
        {
            this.name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWordExperience(string timeArea,string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}",name,sex,age);
            Console.WriteLine("工作经历：{0} {1}",timeArea,company);
        }

        public Object Clone()
        {
            //注意：该复制为浅复制，复制值类型是没问题，但对于引用类型，只会复制对象的引用，而不会将引用的对象也一并的复制。
            return (Object)this.MemberwiseClone();
        }
    }
}
