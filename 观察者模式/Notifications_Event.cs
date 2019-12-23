using System;
namespace 观察者模式
{
    public interface Notifications_Event
    {
        void Notify();
        string SubjectState { get; set; }
    }
}
