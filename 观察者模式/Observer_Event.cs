using System;
namespace 观察者模式
{
    public abstract class Observer_Event
    {
        protected string name;
        public Observer_Event(string name)
        {
            this.name = name;
        }
        
    }
}
