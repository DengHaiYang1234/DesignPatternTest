using System;
namespace 原型模式
{
    public class ResumeShallowCopy
    {
        string name;
        string sex;
        string age;
        string timeArea;
        string company;

        WorkExperienceShallowCopy work;


        public ResumeShallowCopy(string name)
        {
            this.name = name;
            work = new WorkExperienceShallowCopy();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWordExperience(string timeArea, string company)
        {
            work.WorkDate = timeArea;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public Object Clone()
        {
            //注意：该复制为浅复制，复制值类型是没问题，但对于引用类型，只会复制对象的引用，而不会将引用的对象也一并的复制。
            return (Object)this.MemberwiseClone();
        }
    }
}
