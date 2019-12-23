using System;
/*
 * 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建的对象。
 *
 * 不用重新初始化对象，而是动态得获得对象运行时的状态。
 * 浅复制，被复制对象的所有变量都含有与原来的对象相同的值，而所有的对其他对象的引用都仍然指向原来的对象。
 * 深复制，把引用对象的变量指向复制过的新对象，而不是原来的被引用的对象。（实例化一个新对象用于保存拷贝的数据）
*/

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //正常
            //Resume a = new Resume("大鸟");
            //a.SetPersonalInfo("男", "29");
            //a.SetWordExperience("1998-2000", "XX公司");

            //Resume b = (Resume)a.Clone();
            //b.SetWordExperience("1998-2000", "YY企业");

            //Resume c = (Resume)a.Clone();
            //c.SetPersonalInfo("男", "24");

            //a.Display();
            //b.Display();
            //c.Display();


            //浅复制
            //ResumeShallowCopy a = new ResumeShallowCopy("大鸟");
            //a.SetPersonalInfo("男", "29");
            //a.SetWordExperience("1998-2000", "XX公司");

            //ResumeShallowCopy b = (ResumeShallowCopy)a.Clone();
            //b.SetWordExperience("1998-2000", "YY企业");

            //ResumeShallowCopy c = (ResumeShallowCopy)a.Clone();
            //c.SetPersonalInfo("男", "24");

            //a.Display();
            //b.Display();
            //c.Display();


            //深复制
            ResumeDeepCopy a = new ResumeDeepCopy("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWordExperience("1998-2000", "XX公司");

            ResumeDeepCopy b = (ResumeDeepCopy)a.Clone();
            b.SetWordExperience("1998-2000", "YY企业");

            ResumeDeepCopy c = (ResumeDeepCopy)a.Clone();
            c.SetPersonalInfo("男", "24");

            a.Display();
            b.Display();
            c.Display();
        }
    }
}
