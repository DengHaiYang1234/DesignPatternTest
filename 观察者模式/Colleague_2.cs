using System;
namespace 观察者模式
{
    public class Colleague_2 : Observer
    {
        public Colleague_2(string name,Notifications notify) : base(name,notify)
        {
            
        }

        public override void Update()
        {
            Console.WriteLine("{0}  {1}快点关闭手机", notify.SubjectState, name);
        }
    }
}
