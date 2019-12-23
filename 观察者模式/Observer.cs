using System;
namespace 观察者模式
{
    public abstract class Observer
    {
        protected string name;
        protected Notifications notify;

        public Observer(string name, Notifications notify)
        {
            this.name = name;
            this.notify = notify;
        }

        public abstract void Update();
    }
}
