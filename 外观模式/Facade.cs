using System;
namespace 外观模式
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwoS two;
        SubSystemThere there;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwoS();
            there = new SubSystemThere();
        }

        public void MethodA()
        {
            Console.WriteLine("方法组一");
            one.MehodOne();
            two.MehodTwo();
            there.MehodOThree();
        }

        public void MethodB()
        {
            Console.WriteLine("方法组二");
            two.MehodTwo();
            there.MehodOThree();
        }
             
    }
}
