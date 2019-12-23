using System;
namespace 原型模式
{
    public class ResumeDeepCopy
    {
        string name;
        string sex;
        string age;
        string timeArea;
        string company;

        WorkExperienceDeepCopy work;


        public ResumeDeepCopy(string name)
        {
            this.name = name;
            work = new WorkExperienceDeepCopy();
        }

        public ResumeDeepCopy(WorkExperienceDeepCopy work)
        {
            this.work = (WorkExperienceDeepCopy)work.Clone();
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
            ResumeDeepCopy obj = new ResumeDeepCopy(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
