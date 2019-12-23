using System;
using System.Collections.Generic;
namespace 观察者模式
{
    public delegate void EventHandler();
    public class Boss_Event : Notifications_Event
    {
        public event EventHandler Update;
        string action;

        public string SubjectState { get { return action; } set { action = value; } }

        public void Notify()
        {
            Update();
        }
    }
}
